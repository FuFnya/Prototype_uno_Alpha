using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Move : MonoBehaviour

{
    public int sceneBuildIndex;
    public Vector2 playerPos;
    public VectorValue playerStorage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger Entered");

        if (collision.tag == "Player")
        {
            playerStorage.InitValue = playerPos;
            print("Switch Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
