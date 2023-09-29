using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > LevelMarkers.LevelThreeHeight.transform.position.y)
        {
            level = 1;
        }else if (transform.position.y > LevelMarkers.LevelTwoHeight.transform.position.y)
        {
            level = 2;
        }else if(transform.position.y > LevelMarkers.LevelOneHeight.transform.position.y)
        {
            level = 3;
        }
        else
        {
            level = 4;
        }
    }
}
