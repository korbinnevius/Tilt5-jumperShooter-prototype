using System;
using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public static Dictionary<PlayerIndex, Transform> Levels = new Dictionary<PlayerIndex, Transform>();
    private Ship.Player _player;

    private void Awake()
    {
        _player = GetComponent<Ship.Player>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > LevelMarkers.LevelThreeHeight.transform.position.y)
        {
            Levels[_player.PlayerIndex] = LevelMarkers.LevelThreeHeight;
        }else if (transform.position.y > LevelMarkers.LevelTwoHeight.transform.position.y)
        {
            Levels[_player.PlayerIndex] = LevelMarkers.LevelTwoHeight;
        }else if(transform.position.y > LevelMarkers.LevelOneHeight.transform.position.y)
        {
            Levels[_player.PlayerIndex] = LevelMarkers.LevelOneHeight;
        }
        else
        {
            Levels[_player.PlayerIndex] = transform;
        }
    }
}
