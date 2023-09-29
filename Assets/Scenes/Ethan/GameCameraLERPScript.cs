// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class GameCameraLERPScript : MonoBehaviour
// {
//
//     private Vector3 Target1;
//     private Vector3 Target2;
//     public Transform GameBoard;
//     public Transform Level1Area;
//     public Transform Level2Area;
//     public Transform Level3Area;
//     private bool isLerping;
//     public float Speed;
//
//     private void Start()
//     {
//         Target1 = transform.position;
//         Target2 = transform.position;
//
//     }
//
//     private void Update()
//     {
//         isLerping = true;
//     }
//
//     private void OnTriggerEnter(Collider other)
//     {
//         transform.position = Vector3.Lerp (Target1, Target2, Speed * Time.deltaTime);    
//     }
//
//     // void FixedUpdate()
//     // {
//     //     if (isLerping) 
//     //     {
//     //         transform.position = Vector3.Lerp (Target1, Target2, Speed * Time.deltaTime);
//     //     }
//     //
//     // }
//     
// }
