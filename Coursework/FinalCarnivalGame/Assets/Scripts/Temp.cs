using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public float dropoffPosition = -12f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition += Vector3.left;
        transform.Translate(Vector3.left * Time.deltaTime * 3);

        if (transform.position.x < dropoffPosition)
        {
            Destroy(gameObject);
        }

    }

}
