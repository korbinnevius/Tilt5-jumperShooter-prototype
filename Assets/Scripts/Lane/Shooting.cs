using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;

    private float timeLastPressed = -5;
    public float shootFrequency;
    public float shotspeed;

    /// <summary>
    /// The Player component that is ME. It me.
    /// </summary>
    private Player player;
  //  public float destroyafter;

  private void Awake()
  {
      player = GetComponent<Player>();
  }

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
        
        //tell the bullet that it me, i am the one who shot
        Shot.GetComponent<Bullet>().theShooter = player;
        Shot.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * shotspeed);
       //Destroy(Shot, destroyafter);
    }
}
