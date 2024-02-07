using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/Goblin Loot Table")]
public class GoblinDropDataSO : ScriptableObject
{
    [field: SerializeField]
    public GameObject[] Drops;
}

