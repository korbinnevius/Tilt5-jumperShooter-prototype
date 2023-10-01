using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUllet : MonoBehaviour
{
 public float bulletspeed;
 [SerializeField] private Rigidbody _rigidbody;

 private void Awake()
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
 }
}
