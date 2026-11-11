using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public static SpawnBall Instance;


    public GameObject ballPrefab;


    private void Start()
    {
        ballSpawn();
    }

    public void ballSpawn()
    {
        Instantiate(ballPrefab);
    }

    private void Awake()
    {
        Instance = this;
    }

}
