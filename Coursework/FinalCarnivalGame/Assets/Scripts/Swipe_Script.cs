using UnityEngine;
using UnityEngine.InputSystem;

public class Swipe_Script : MonoBehaviour
{
    bool hasSwiped = false;

    Vector2 startPos;
    Vector2 endPos;

    public float throwForce = 0.1f; // This is the force in which the ball will be thrown when the player swipes on it

    Rigidbody2D rb;
    bool isDragging = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // This section of code is for testing on my PC as it was much easier for me to test on PC then go to phone rather than constantly switching between the two.
        if (Mouse.current != null)
        {
            if (Mouse.current.leftButton.wasPressedThisFrame && !hasSwiped) //This registers where the mouse was when it was initially pressed
            {
                startPos = Mouse.current.position.ReadValue();
                isDragging = true;
            }

            if (Mouse.current.leftButton.wasReleasedThisFrame && isDragging) //This registers where the mouse stopped being pressed (this will also make sure the player was dragging and not clicking)
            {
                endPos = Mouse.current.position.ReadValue();
                ThrowBall(); //This calls the throw ball function
            }
        }

        // This section of code is for gameplay on a Phone instead of PC
        if (Touchscreen.current != null) //This will check whether a touchscreen is available
        {
            var touch = Touchscreen.current.primaryTouch; //

            if (touch.press.wasPressedThisFrame && !hasSwiped)
            {
                startPos = touch.position.ReadValue();
                isDragging = true;
            }

            if (touch.press.wasReleasedThisFrame && isDragging)
            {
                endPos = touch.position.ReadValue();
                ThrowBall();
            }
        }
    }

    void ThrowBall()
    {
        hasSwiped = true;

        Vector2 direction = endPos - startPos;

        rb.linearVelocity = Vector2.zero;

        rb.AddForce(direction * throwForce, ForceMode2D.Impulse);

        isDragging = false;
    }
}