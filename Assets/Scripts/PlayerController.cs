using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Control Modifiers")]
    public float speedMultiplier = 2f;
    public float sidePushForce = 0.1f;
    public float turnRate = 2;

    private Rigidbody rb;
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        tf = gameObject.transform;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.timeScale == 1)
        {

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForceAtPosition(new Vector3(-sidePushForce * Time.deltaTime, 0, 0), tf.position + new Vector3(0, 0.5f, 0));
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForceAtPosition(new Vector3(sidePushForce * Time.deltaTime, 0, 0), tf.position + new Vector3(0, 0.5f, 0));                
            }

            float angle = tf.eulerAngles.z;
            if (angle > 180)
            {
                angle = 360 - angle;
            }
            else
            {
                angle = -angle;
            }
            tf.Translate(new Vector3(angle * turnRate * Time.deltaTime, 0, speedMultiplier * Time.deltaTime), Space.World);
        }   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            SceneManager.LoadScene("GameOver");
            SceneManager.UnloadSceneAsync("MainGame");
        }
    }
}
