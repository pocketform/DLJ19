using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Dynamic : MonoBehaviour
{
    [SerializeField] private LayerMask m_WhatIsGround;							// A mask determining what is ground to the character
    [SerializeField] private Transform m_GroundCheck;                           // A position marking where to check if the player is grounded.
    const float k_GroundedRadius = .2f;                                         // Radius of the overlap circle to determine if grounded


    public float moveSpeed = 5;
    public float jumpSpeed = 10;

    bool grounded = true;
    bool jump = false;
    float curentHM;

    public Rigidbody2D myRB;

    private Vector2 m_Velocity = Vector2.zero;
    // Start is called before the first frame update

    private void Awake()
    {
        myRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        curentHM = Input.GetAxis("Horizontal");
        print(Input.GetAxis("Horizontal"));
    }

    private void FixedUpdate()
    {
        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                grounded = true;
                //print(grounded);
            }
        }

        float hMove = curentHM * moveSpeed;
        float vMove;

        if (jump && grounded)
        {
            vMove = jumpSpeed;
            jump = false;
            grounded = false;
        }
        else
        {
            vMove = 0;
        }
        characterMove(hMove, vMove);        
    }

    void characterMove(float hMove, float vMove)
    {
        Vector2 currentForce = new Vector2(hMove, gameObject.GetComponent<Rigidbody2D>().velocity.y);

        //gameObject.GetComponent<Rigidbody2D>().AddForce(currentForce, ForceMode2D.Impulse);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.SmoothDamp(gameObject.GetComponent<Rigidbody2D>().velocity, currentForce, ref m_Velocity, 0.05f);

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, vMove * 10));
    }
}
