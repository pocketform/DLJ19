using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controll : MonoBehaviour
{
    public CrossSceneDate MyCSD;

    public Slider slider;
    public Text scoreText;

    public int scoreInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = CrossSceneDate.G_Life;

        scoreInt = CrossSceneDate.G_Score;
        scoreText.text = scoreInt.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //slider.value += 1;
            ChangeLive(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //slider.value -= 1;
            ChangeLive(-1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //scoreInt += 1;
            //scoreText.text = scoreInt.ToString();
            changeScore(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //scoreInt -= 1;
            //scoreText.text = scoreInt.ToString();
            changeScore(-1);
        }
    }

    public void ChangeLive(int num)
    {
        slider.value += num;
        CrossSceneDate.G_Life = (int)slider.value;//lecture10
    }
    public void changeScore(int num)
    {
        //print("in changeScore");
        scoreInt += num;
        scoreText.text = scoreInt.ToString();
        CrossSceneDate.G_Score = scoreInt;//lecture10
    }
}
