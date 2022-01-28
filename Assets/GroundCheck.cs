using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<gacksPlayerMovement>().isGrounded = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<gacksPlayerMovement>().isGrounded = false;
    }
}
