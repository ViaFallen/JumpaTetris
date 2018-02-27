using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static int gridWidth = 10;
    public static int gridHeight = 20;

    public bool IsTetrominoInsideAGrid(Vector3 pos)
    {
        return (
            (int)pos.x >= 0 &&
            (int)pos.x < gridWidth &&
            (int)pos.y >= 0
        );
    }

    public Vector3 Round(Vector3 pos)
    {
        return new Vector3(
            Mathf.Round(pos.x),
            Mathf.Round(pos.y),
            Mathf.Round(pos.z)
        );
    }
}
