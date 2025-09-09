using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnTime = 2.0f;
    public float xSpawnPos = 18;
    private float ySpawnPos;
    public GameObject enemyShip;

    public bool isGamePlaying;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Invoke("StartGame", 0);
        isGamePlaying = true;
        InvokeRepeating("SpawnShip", 2f, 2f);
    }
    
    void StartGame()
    {
        isGamePlaying = true;
        InvokeRepeating("SpawnShip", 2f, 2f);
    }

    void SpawnShip()
    {
        if (isGamePlaying)
        {
            //yield return new WaitForSeconds(spawnTime);
            //ySpawnPos = UnityEngine.Random.Range(-1.0f, 13.0f);
            Vector3 spawnPos = new Vector3(xSpawnPos, Random.Range(-1f, 13f), 0);
            Instantiate(enemyShip, spawnPos, Quaternion.identity);
            //new Vector3(xSpawnPos, UnityEngine.Random.Range(-1.0f, 13.0f), 0)
        }
    }
}
