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
}
