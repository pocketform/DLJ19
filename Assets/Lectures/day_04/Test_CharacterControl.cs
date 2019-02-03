using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_CharacterControl : MonoBehaviour
{
    public CharacterController2D myCC2D;

    public float maxMoveSpeed = 15;

    public float moveSpeed;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = maxMoveSpeed * Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        myCC2D.Move(moveSpeed, false, jump);
        jump = false;
    }
}
