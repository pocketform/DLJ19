using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    int a = 1;
    float b = 3.1415926f;
    string c = "hello";

    int A;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("GET");

        //Debug.Log(c);        

    }

    // Update is called once per frame
    void Update()
    {
        A = ++a;
        

        if (A>5)
        {
            Debug.Log(A);
        }
        else
        {
            Debug.Log(" A < 5");
        }
    }
}
