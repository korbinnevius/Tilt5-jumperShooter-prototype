using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingShot : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Bullet"))
      {
         Destroy(gameObject);
      }
   }
}
