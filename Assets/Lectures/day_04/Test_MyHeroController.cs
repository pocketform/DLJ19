using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_MyHeroController : MonoBehaviour
{
    public float moveSpeed = 1;
    public float jumpSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        ControlCharecter();
    }

    void ControlCharecter()
    {

        Vector2 nextHorizontal = Vector2.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        Vector2 nextVertical = Vector2.up * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector2 nextPosition = nextVertical + nextHorizontal;
        nextPosition += gameObject.GetComponent<Rigidbody2D>().position;
        gameObject.GetComponent<Rigidbody2D>().MovePosition(nextPosition);

        //gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up);
        //gameObject.GetComponent<Rigidbody2D>().velocity = nextPosition;
    }
}
