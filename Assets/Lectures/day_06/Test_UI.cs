using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_UI : MonoBehaviour
{
    public float testF = 0;
    public bool testB = true;
    public string testS = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintTest_F()
    {
        print("TestF: " + testF);
        testF += 1;
    }

    public void PrintTest_B()
    {
        print("TestF: " + testB);
        testB = !testB;
    }

    public void Slider_Test()
    {
        print(GameObject.Find("Slider").GetComponent<Slider>().value);
    }

    public void Scrollbar_Test()
    {
        print(GameObject.Find("Scrollbar").GetComponent<Scrollbar>().value);
    }

    public void PrintOption()
    {
        switch(GameObject.Find("Dropdown").GetComponent<Dropdown>().value)
        {
            case 0:
                print(GameObject.Find("Dropdown").GetComponent<Dropdown>().value);               
                break;
            case 1:
                print(GameObject.Find("Dropdown").GetComponent<Dropdown>().value);
                break;
            case 2:
                print(GameObject.Find("Dropdown").GetComponent<Dropdown>().value);
                break;
        }
    }

    public void PrintString()
    {
        print(GameObject.Find("InputField").GetComponent<InputField>().text);
    }

    public void PrintStringC()
    {
        testS = "ccc";
        print("TestF: " + testS);
    }
}
