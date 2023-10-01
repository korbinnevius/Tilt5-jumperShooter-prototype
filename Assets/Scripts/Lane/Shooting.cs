using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour

{
    public GameObject Bullet;

    private float timeLastPressed = -5;
    public float shootFrequency;

    [SerializeField] private Transform firePoint;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ShootCheck();
        }
    }

    private void ShootCheck()
    {
        float timeSinceLastPressed = Time.time - timeLastPressed;
        if (timeSinceLastPressed >= shootFrequency)
        {
            Shoot();
            timeLastPressed = Time.time;
        }
    }

    public void Shoot()
    {
        Instantiate(Bullet, firePoint.position, firePoint.rotation);
    }
}
