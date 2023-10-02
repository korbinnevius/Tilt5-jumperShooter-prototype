using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    //target location is public for ease of editor access to the transform
    public Transform targetLocation;

    // public bool isExit;
    public float distance = 0.2f;

    
    //Below code for an entrance and an exit. Simply comment out if you don't want the player to go back through
    private void Start()
    {
        // if (isExit == false)
        // {
        //     targetLocation = GameObject.FindGameObjectWithTag("ExitPortal").GetComponent<Transform>();
        // }
        // else
        // {
        //     targetLocation = GameObject.FindGameObjectWithTag("EntrancePortal").GetComponent<Transform>();
        // }
    }

    //Finds the transform of a public object and uses that as an anchor for teleporting positions
    void OnTriggerEnter(Collider other)
    {
        if (Vector3.Distance(transform.position, other.transform.position) > distance)
        {
            var targetPosition = targetLocation.position;
            other.transform.position = new Vector3(targetPosition.x, targetPosition.y,
                targetPosition.z);
        }
    }
}
