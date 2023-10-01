using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    public Transform targetLocation;

    // public bool isExit;
    public float distance = 0.2f;

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
