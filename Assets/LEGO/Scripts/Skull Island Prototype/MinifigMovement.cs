using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinifigMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (transform.forward / 1) * speed;
    }
}
