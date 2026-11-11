using UnityEngine;

public class Bucket_Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Score.Instance.addScore();
            Destroy(other.gameObject);
        }
    }
}
