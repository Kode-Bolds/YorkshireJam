using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            SceneManager.UnloadSceneAsync("MainGame");
        }
    }
}
