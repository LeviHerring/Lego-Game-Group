using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackKingKongDeath : MonoBehaviour
{
    public float timer = 40f;

    public GameObject victory;

    public GameObject defeat;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject victory = GameObject.Find("CanvasVictory");
        //GameObject defeat = GameObject.Find("CanvasDefeat");

        victory.SetActive(false);

        defeat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if(timer >= 0)
        {
            victory.SetActive(true);
        }



    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Plane")
        {
            gameObject.SetActive(false);

            defeat.SetActive(true);
        }
    }
}

