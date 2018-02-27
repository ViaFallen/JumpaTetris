using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static int gridWidth = 10;
    public static int gridHeight = 20;

    private void Start()
    {
        GenerateTetromino();
    }

    private string GetRandomTetromino()
    {
        int val = Random.Range(0, 7);
        string tetrominoName = "TetrominoT";

        switch(val)
        {
            case 0:
                tetrominoName = "TetrominoI";
                break;
            case 1:
                tetrominoName = "TetrominoJ";
                break;
            case 2:
                tetrominoName = "TetrominoL";
                break;
            case 3:
                tetrominoName = "TetrominoT";
                break;
            case 4:
                tetrominoName = "TetrominoO";
                break;
            case 5:
                tetrominoName = "TetrominoS";
                break;
            case 6:
                tetrominoName = "TetrominoZ";
                break;
        }

        return "Prefabs/" + tetrominoName;
    }

    public void GenerateTetromino()
    {
        GameObject tetromino = (GameObject)Instantiate(Resources.Load(GetRandomTetromino(), typeof(GameObject)),
                                                       new Vector3(5.0f, 18.0f, 0.0f),
                                                       Quaternion.identity);
    }

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
