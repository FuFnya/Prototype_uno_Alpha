using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDungeonGenerator : MonoBehaviour
{
    [SerializeField]
    protected TilemapVisualizer tilemapVisualizer = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    [SerializeField]
    protected string GameSeed = "Default";

    [SerializeField]
    protected int CurrentSeed = 0;

    public void GenerateDungeon()
    {
        CurrentSeed = GameSeed.GetHashCode();
        UnityEngine.Random.InitState(CurrentSeed);
        tilemapVisualizer.Clear();
        RunProceduralGeneration();
    }

    protected abstract void RunProceduralGeneration();
}
