using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    
    public float fireInterval = 0.5f;
    public float bulletSpeed = 20;
    public Transform spawnPoint;
    public GameObject bulletObject;

    float nextFire;

    void Start()
    {
        nextFire = Time.time + fireInterval;
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireInterval;
            fire();
        }
    }

    void fire()
    {
        var bullet = Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }
}