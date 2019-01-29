using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    int global_variable = 50;

    // Start is called before the first frame update
    void Start()
    {
        int a = 100;

        {
            //int a = 200;
            Debug.Log(a);

        }

    }

    void Awake()
    {
        int a = 0;
        {
            //int a = 10;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void some_function()
    {
        int a = 400;
        char letter = 'b';
    }


}
