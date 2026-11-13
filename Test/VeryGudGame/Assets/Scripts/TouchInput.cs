using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch; //To avoid errors

public class TouchInput : MonoBehaviour
{
    public GameObject PlayerTouchArea;
    private Vector3 TouchPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    protected void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Touch.activeTouches)
        {
            if (touch.isTap) //If the dectected touch is a tap
            {
                Vector3 TouchPos = Camera.main.ScreenToWorldPoint(touch.screenPosition);
                TouchPos.z = 0; //Appear on Screen
                Debug.Log("Imma Touch");
                Instantiate(PlayerTouchArea, TouchPos, Quaternion.identity);

            }
            break;
        }

    }
}
