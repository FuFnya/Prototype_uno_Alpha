using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Move : MonoBehaviour

{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger Entered");

        if (collision.tag == "Player")
        {
            print("Switch Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
