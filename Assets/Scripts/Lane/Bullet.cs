using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public Player theShooter;
    public GameObject BB1;
    public GameObject BB2;
    public GameObject BB3;
    public GameObject BB4;
    public GameObject BB5;
    private  float TimesinceShot = -1;
    public float safetime;
    void OnTriggerEnter(Collider other)
    {
       // float timesinceShooting = Time.time - TimesinceShot;
        //if (timesinceShooting > safetime)
      //  {

      var player = other.gameObject.GetComponentInParent<Player>();
      if (player != theShooter)
      {
          Destroy(BB1);
          Destroy(BB2);
          Destroy(BB3);
          Destroy(BB4);
          Destroy(BB5);
      }
      else
      {
          //don't destroy the person who shot these bullets!
      }
      // if (other.CompareTag("Player"))
          //  {
                //Destroy(other.gameObject);
          //  }
      //  }
    }
    /*private void Awake()
 {
     _rigidbody = GetComponent<Rigidbody>();
 }
 void Update()
 { 
     BulletFire();
 }
 void BulletFire()
 {
     _rigidbody.AddForce(Vector3.forward * bulletspeed);
 }*/
}
