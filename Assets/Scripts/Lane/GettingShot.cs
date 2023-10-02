using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;

public class GettingShot : MonoBehaviour
{
   private Player _player;

   private void Awake()
   {
      _player = GetComponent<Player>();
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Bullet"))
      {
         var bullet = other.GetComponentInParent<Bullet>();
         if (bullet.theShooter != _player)
         {
            //hit by bullet that i did not shoot
            Destroy(gameObject);
         }
      }
   }
}
