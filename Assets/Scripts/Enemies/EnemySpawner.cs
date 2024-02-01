using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject goblin;

    [SerializeField]
    private float interval = 1.5f;

    private int times = 5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(interval, goblin));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        GameObject newEnemy = Instantiate(enemy, 
            new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), 0), Quaternion.identity);
        times--;
        if (times > 0)
        {
            StartCoroutine(spawnEnemy(interval, enemy));
        }
        yield return interval;
    }
}
