using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckEpic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //BoxCollider collider = GetComponent<BoxCollider>();

        GameObject kingKong = GameObject.Find("Player");
        gacksEpicPM playerScript = kingKong.GetComponent<gacksEpicPM>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Platform")
        {
            gacksEpicPM.isGrounded = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        gacksEpicPM.isGrounded = false;
    }
}

