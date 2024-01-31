using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Move : MonoBehaviour

{
    public Vector2 playerPos;
    public VectorValue playerStorage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger Entered");

        if (collision.tag == "Player")
        {
            //playerStorage.InitValue = playerPos;
            DontDestroyOnLoad(FindAnyObjectByType<Player>().gameObject);
            DontDestroyOnLoad(GameObject.FindGameObjectWithTag("MainCamera"));
            Loader.load(Loader.Scene.Level2);
        }
    }
}
