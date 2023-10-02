using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BUllet : MonoBehaviour
{
    public GameObject BB1;
    public GameObject BB2;
    public GameObject BB3;
    public GameObject BB4;
    public GameObject BB5;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            Destroy(BB1);
            Destroy(BB2);
            Destroy(BB3);
            Destroy(BB4);
            Destroy(BB5);
        }
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
