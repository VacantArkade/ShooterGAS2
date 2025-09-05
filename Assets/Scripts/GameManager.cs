using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnTime = 2.0f;
    public float ySpawnPos = 18;
    public GameObject enemyShip;

    public bool isGamePlaying;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("StartGame", 0);
    }
    
    void StartGame()
    {
        isGamePlaying = true;
        StartCoroutine(SpawnShips());
    }

    IEnumerator SpawnShips()
    {
        while (isGamePlaying)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemyShip, new Vector3(Random.Range(-3, 3), ySpawnPos, 0), Quaternion.identity);
        }
    }
}
