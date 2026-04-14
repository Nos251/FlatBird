using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-1f, 1f);
        Vector3 spawnPosY = new Vector3(transform.position.x, randomY, 0);
        
        Instantiate(pipePrefab, spawnPosY, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
