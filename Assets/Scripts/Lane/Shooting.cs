using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour

{
    public GameObject Bullet;

    private float timeLastPressed = -5;
    public float shootFrequency;
    public float shotspeed;
    public float destroyafter;
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
        GameObject Shot = Instantiate(Bullet, transform.position, Quaternion.identity);
                    Rigidbody instFoamRB = Shot.GetComponent<Rigidbody>();
        
                    instFoamRB.AddForce(gameObject.transform.forward * shotspeed);
                    Destroy(Shot, destroyafter);
    }
}
