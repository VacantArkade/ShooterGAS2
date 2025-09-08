using UnityEngine;

public class EnemyShipController : MonoBehaviour
{
    public int enemyHealth = 3;
    public float shipDropSpeed = -3.0f;

    //Control the Sine Movement
    public float _frequency = 6.0f;
    public float _distance = 0.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(shipDropSpeed * Time.deltaTime, 0, 0);
        transform.Rotate(60f * Time.deltaTime, 0, 0);
        transform.position = new Vector3(transform.position.x, YSine(), transform.position.z);
    }

    public float YSine()
    {
        return Mathf.Sin(Time.time * _frequency * _distance);
    }
}
