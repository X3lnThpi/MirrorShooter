using UnityEngine;

public class Shooting : MonoBehaviour
{
    public static Shooting instance;

    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletSpeed;
    }
}
