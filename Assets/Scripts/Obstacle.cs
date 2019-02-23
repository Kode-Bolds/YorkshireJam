using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.timeScale == 1)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        }

        if(transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Obstacle")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
