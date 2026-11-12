using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 15f;
    public float xBoundary = 2.2f;

    void Update()
    {
        if (!UIManager.isGameActive) return;

        float horizontalInput = Input.acceleration.x;

        #if UNITY_EDITOR
        if (Input.GetAxis("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        #endif

        float xOffset = horizontalInput * moveSpeed * Time.deltaTime;
        float newXPosition = Mathf.Clamp(transform.position.x + xOffset, -xBoundary, xBoundary);
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Traffic"))
        {
            #if UNITY_ANDROID || UNITY_IOS
            Handheld.Vibrate();
            #endif

            UIManager ui = FindFirstObjectByType<UIManager>();
            if (ui != null)
            {
                ui.ShowGameOver();
            }

            Time.timeScale = 0f;
        }
    }
}