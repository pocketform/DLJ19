using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_InterActive : MonoBehaviour
{

    public int score = 0;
    public float Vforce = 5;
    public float Hforce = 5;
    private UI_Controll UIC;

    public GameObject click;

    private void Awake()
    {
        UIC = GameObject.Find("Canvas").GetComponent<UI_Controll>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.tag);

        if (collision.gameObject.tag == "Coins")
        {            
            UIC.changeScore(1);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            UIC.ChangeLive(-1);

            Vector2 blockForce = new Vector2(0, Vforce);

            if (gameObject.GetComponent<CCAnimation>().faceRight == true)
            {
                blockForce.x = -Hforce;
            }
            else
            {
                blockForce.x = Hforce;
            }

            //print(blockForce);

            gameObject.GetComponent<CCAnimation>().Freeze(blockForce);

            //this.gameObject.GetComponent<Rigidbody2D>().AddForce(blockForce * 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            click.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            click.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Portal" && Input.GetKeyDown(KeyCode.W))
        {
            //print(CrossSceneDate.G_Scene);
            if (CrossSceneDate.G_Scene == 1)
            {
                CrossSceneDate.ChangeLevelTwo();
            }
            else if (CrossSceneDate.G_Scene == 2)
            {
                CrossSceneDate.ChangeMainManu();
            }
        }
    }
}
