using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController2 : MonoBehaviour
{

    public float movementSpeed = 50.0f;

    public float jumpHeight = 15.0f;

    public bool isGrounded = true;

    public Transform groundCheck;

    [SerializeField] private float jumpForce = 10f;

    void Start()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        isGrounded = true;
    }

    void Update()
    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //if ((Physics.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Platform"))))
        //{
        //    isGrounded = true;
        //}
        //else
        //{
        //    isGrounded = false;
        //}

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody.position += Vector3.back * Time.deltaTime * movementSpeed;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
//<<<<<<< HEAD
            transform.localRotation = Quaternion.Euler(0, 90, 0);
//=======
            transform.localRotation = Quaternion.Euler(0, 90, 0); 
//>>>>>>> 4980765ff08f72aa9ebfbaa2d1420add8a408797
            rigidbody.position += Vector3.left * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
            rigidbody.position += Vector3.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpForce, 1);

        }


//<<<<<<< HEAD
    }

//=======
//>>>>>>> 4980765ff08f72aa9ebfbaa2d1420add8a408797
    //public void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Platform")
    //    {
    //        isGrounded = true; 
    //    }
    //}


}
