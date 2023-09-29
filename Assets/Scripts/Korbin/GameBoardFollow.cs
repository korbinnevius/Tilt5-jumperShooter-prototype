using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;

public class GameBoardFollow : MonoBehaviour
{
    public PlayerIndex playerToFollow;
    public Vector3 offset;

    private Vector2 goalPos;

    public float gameBoardLerpSpeed;
    // Update is called once per frame
    void Update()
    {
        if (TryGetLevel(out var level))
        {
            goalPos = level.transform.position + offset;
        }

        transform.position = Vector3.MoveTowards(transform.position, goalPos, Time.deltaTime*gameBoardLerpSpeed);
    }

    //Hunter says Hi
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
