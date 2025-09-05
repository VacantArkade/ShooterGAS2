using UnityEngine;

public class ObjectKillScript : MonoBehaviour
{
    public float killTime = 0.75f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, killTime);
    }

}
