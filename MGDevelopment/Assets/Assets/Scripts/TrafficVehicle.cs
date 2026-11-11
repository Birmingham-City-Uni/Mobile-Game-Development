using UnityEngine;

public class TrafficVehicle : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < -12f)
        {
            Destroy(gameObject);
        }
    }
}
