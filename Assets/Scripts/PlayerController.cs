using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Control Modifiers")]
    public float speedMultiplier = 2f;
    public float turnRate = 2;
    public float sidePushForce = 0.1f;

    private Rigidbody rb;
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        tf = gameObject.transform;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddRelativeForce(new Vector3(sidePushForce / (Mathf.Max(rb.transform.rotation.z, 1)), 0, 0), ForceMode.Impulse);
            rb.AddTorque(new Vector3(0, -turnRate, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddRelativeForce(new Vector3(sidePushForce / (Mathf.Max(rb.transform.rotation.z, 1)), 0, 0), ForceMode.Impulse);
            rb.AddTorque(new Vector3(0, turnRate, 0));
        }
        tf.Translate(new Vector3(tf.forward.x * speedMultiplier * Time.deltaTime, 0, 0), Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.AddRelativeForce(new Vector3(0, 0, -50), ForceMode.Impulse);
    }
}
