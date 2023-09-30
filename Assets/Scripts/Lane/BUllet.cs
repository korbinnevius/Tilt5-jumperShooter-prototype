using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUllet : MonoBehaviour
{
 public float bulletspeed;
 
 
    void Update()
    {
       transform.position += Vector3.forward * bulletspeed;
    }
}
