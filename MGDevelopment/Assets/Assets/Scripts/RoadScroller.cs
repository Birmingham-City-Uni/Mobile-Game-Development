using UnityEngine;

public class RoadScroller : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float resetPositionY = -12f;
    public float spawnPositionY = 12f;

    void Update()
    {
        if (!UIManager.isGameActive) return;

        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        
        if (transform.position.y <= resetPositionY)
        {
            transform.position = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
        }
    }
}
