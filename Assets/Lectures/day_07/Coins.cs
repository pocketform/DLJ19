using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int score = 0;

    private UI_Controll UIC;

    private void Awake()
    {
        UIC = GameObject.Find("Canvas").GetComponent<UI_Controll>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //print("get collisionEnter");
        if (collision.gameObject.name == "Castlevania_Animation")
        {
            UIC.changeScore(1);
        }

        Destroy(this);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        print("get collisionStay");
    }

    void OnTriggerEnter(Collider other)
    {
        print("get triggerEnter");
    }


    //collision
}
