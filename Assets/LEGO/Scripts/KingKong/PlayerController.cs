using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 50.0f;

    public float jumpHeight = 15.0f;

    public bool isGrounded = true;

    public Transform groundCheck;

    void Start()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        isGrounded = true; 
    }

    void Update()
    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if ((Physics.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Platform"))))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
            transform.localScale = new Vector3(0.07227582f, 0.07227582f, -0.07227582f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody.position += Vector3.back * Time.deltaTime * movementSpeed;
            transform.localScale = new Vector3(0.07227582f, 0.07227582f, 0.07227582f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidbody.position += Vector3.left * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.position += Vector3.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidbody.position += Vector3.up * jumpHeight;
            isGrounded = false; 
        }

       
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Platform")
        {
            isGrounded = true; 
        }
    }


    private void FixedUpdate()
    {
        if ((Physics.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"))))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false; 
        }

    }

    }