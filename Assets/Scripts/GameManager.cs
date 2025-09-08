using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnTime = 2.0f;
    public float xSpawnPos = 6;
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
            Instantiate(enemyShip, new Vector3(xSpawnPos, Random.Range(-1, 13), 0), Quaternion.identity);
        }
    }
}
