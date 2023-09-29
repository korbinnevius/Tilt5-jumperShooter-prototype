using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMarkers : MonoBehaviour
{
    public static Transform LevelThreeHeight;
    [SerializeField] Transform _level3Height;
    
    public static Transform LevelTwoHeight;
    [SerializeField] Transform _level2Height;
    
    public static Transform LevelOneHeight;
    [SerializeField] Transform _level1Height;
    // Start is called before the first frame update
    void Awake()
    {
        LevelOneHeight = _level1Height;
        LevelTwoHeight = _level2Height;
        LevelThreeHeight = _level3Height;
    }

    public static Transform GetTransformFromLevelInt(int level)
    {
        if (level == 3)
        {
            return LevelThreeHeight;
        }else if (level == 2)
        {
            return LevelTwoHeight;
        }else if (level == 1)
        {
            return LevelOneHeight;
        }
        else
        {
            return null;
        }
    }
}
