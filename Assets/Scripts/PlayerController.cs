using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            tf.Translate(new Vector3((tf.eulerAngles.z - 180) * turnRate * Time.deltaTime, 0, speedMultiplier * Time.deltaTime), Space.World);
            //if (tf.eulerAngles.z < 180)
            //{
            //    tf.Translate(new Vector3(-speedMultiplier * Time.deltaTime, 0, 0), Space.World);
            //}
            //else
            //{
            //    tf.Translate(new Vector3(speedMultiplier * Time.deltaTime, 0, 0), Space.World);
            //}
        }   
    }
}
