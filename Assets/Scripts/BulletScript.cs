using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public bool enemyBullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.GetComponent<EnemyShipController>().enemyHealth--;
            if (other.gameObject.GetComponent<EnemyShipController>().enemyHealth <= 0)
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
