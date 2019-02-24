using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float xBoundRight;
    public float xBoundLeft;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > xBoundRight)
        {
            SceneManager.LoadScene("GameOver");
            SceneManager.UnloadSceneAsync("MainGame");
        }

        if (player.transform.position.x < xBoundLeft)
        {
            SceneManager.LoadScene("GameOver");
            SceneManager.UnloadSceneAsync("MainGame");
        }
    }
}
