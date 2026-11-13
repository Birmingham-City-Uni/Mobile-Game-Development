using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneDistance = 2f;
    public float moveSpeed = 12f;

    private int currentLane = 1;
    private Rigidbody2D rb;
    private Vector2 touchStart;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Keyboard controls for Unity testing
        if (Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeLane(-1);
        }

        if (Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeLane(1);
        }

        // Touchscreen swipe controls for Android
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStart = touch.position;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                Vector2 swipe = touch.position - touchStart;

                if (Mathf.Abs(swipe.x) > Screen.width * 0.08f &&
                    Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
                {
                    ChangeLane(swipe.x > 0 ? 1 : -1);
                }
            }
        }
    }

    void ChangeLane(int direction)
    {
        currentLane = Mathf.Clamp(
            currentLane + direction, 0, 2
        );
    }

    void FixedUpdate()
    {
        float targetX = (currentLane - 1) * laneDistance;

        Vector2 targetPosition = new Vector2(
            targetX, -3f
        );

        rb.MovePosition(Vector2.MoveTowards(
            rb.position,
            targetPosition,
            moveSpeed * Time.fixedDeltaTime
        ));
    }
}