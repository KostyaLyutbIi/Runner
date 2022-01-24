using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounder : MonoBehaviour
{
    public static float leftSide = -2.5f;
    public static float rightSide = 2.5f;
    public float LeftEdge;
    public float RightEdge;

    void Update()
    {
        LeftEdge = leftSide;
        RightEdge = rightSide;
    }
}
