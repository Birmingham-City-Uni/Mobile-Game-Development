using UnityEngine;

public class Bucket_Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Score.Instance.addScore();
            Score.Instance.remainingBalls();
            Destroy(other.gameObject);
            SpawnBall.Instance.ballSpawn();
        }
    }
}
