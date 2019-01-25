using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_CharacterControl : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(speed);
            this.transform.Translate(this.transform.right * speed * Time.deltaTime);
        }
    }
}
