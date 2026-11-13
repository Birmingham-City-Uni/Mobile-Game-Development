using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch; //To avoid errors

public class TouchInputForTaps : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource tapPouring;
    public AudioClip PourSound;

    private void Awake()
    {
        tapPouring = GetComponent<AudioSource>();
    }

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

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tapPouring.PlayOneShot(PourSound);
            Debug.Log("Touches Tap");
        }

    }
}

