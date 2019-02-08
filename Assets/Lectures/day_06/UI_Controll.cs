using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controll : MonoBehaviour
{
    public Slider slider;
    public Text scoreText;

    public int scoreInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slider.value += 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slider.value -= 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            scoreInt += 1;
            scoreText.text = scoreInt.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            scoreInt -= 1;
            scoreText.text = scoreInt.ToString();
        }
    }
}
