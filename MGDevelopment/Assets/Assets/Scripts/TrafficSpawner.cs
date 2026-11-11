using UnityEngine;

public class TrafficSpawner : MonoBehaviour
{
    public GameObject trafficCarPrefab;
    public float spawnInterval = 1.6f;
    public float minX = -1.8f;
    public float maxX = 1.8f;
    public float spawnY = 12f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnCar();
            timer = 0f;
        }
    }

    void SpawnCar()
    {
        if (trafficCarPrefab == null) return;

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);
        Instantiate(trafficCarPrefab, spawnPos, Quaternion.identity);
    }
}
