using System.Collections;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    public float moveSpeed = 3.0f;

    //Control ship move distance
    public float xMin, xMax;
    public float yMin, yMax;

    //Bullet Variables
    public Rigidbody playerBullet;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 30.0f;
    public float fireSpeed = 0.2f;
    public bool canShoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        transform.Translate(xMove * moveSpeed * Time.deltaTime, yMove * moveSpeed * Time.deltaTime, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
            Mathf.Clamp(transform.position.y, yMin, yMax), transform.position.z);

        if (Input.GetButton("Fire1") && canShoot)
        {
            canShoot = false;
            Rigidbody _bullet;
            _bullet = Instantiate(playerBullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as Rigidbody;
            _bullet.AddForce(Vector2.right * 30, ForceMode.Impulse);
            //SoundManager.Instance.PlaySound2D("PlayerFire");
            StartCoroutine(ResetShoot());
        }
    }

    IEnumerator ResetShoot()
    {
        yield return new WaitForSeconds(fireSpeed);
        canShoot = true;
    }
}
