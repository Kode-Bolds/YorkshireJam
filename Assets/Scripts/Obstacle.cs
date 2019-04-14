using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float hopSpeed = 2.5f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            SceneManager.UnloadSceneAsync("MainGame");
        }

        // if wall hit, reflect translation
        if (collision.gameObject.tag == "Wall")
        {
            // forwardDirection = Vector3.Reflect(forwardDirection, transform.);
            transform.Rotate(Vector3.up, 90);
        }
    }

    private void Update()
    {
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
    }
}
