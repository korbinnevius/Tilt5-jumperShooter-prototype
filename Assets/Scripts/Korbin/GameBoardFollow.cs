using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;

public class GameBoardFollow : MonoBehaviour
{
    /// <summary>
    /// What player should the gameboard follow
    /// </summary>
    public PlayerIndex playerToFollow;
    public Vector3 offset;

    private Vector2 goalPos;
    
    /// <summary>
    /// How fast should the camera view should change
    /// </summary>
    public float gameBoardLerpSpeed;
    
    //check position of player and lerp gameboard if necessary
    void Update()
    {
        if (TryGetLevel(out var level))
        {
            goalPos = level.transform.position + offset;
        }
        
        //move towards the level marker you have moved to. if you have moved. 
        transform.position = Vector3.MoveTowards(transform.position, goalPos, Time.deltaTime*gameBoardLerpSpeed);
    }

    //Hunter says Hi
    //follow player
    bool TryGetLevel(out Transform level)
    {
        if (PlayerLevel.Levels.ContainsKey(playerToFollow))
        {
            level = PlayerLevel.Levels[playerToFollow];
            return true;
            
        }
        level = null;
        return false;
    }


}
