using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossSceneDate : MonoBehaviour
{
    public static int G_Life = 10;
    public static int G_Score = 0;
    public static int G_Scene = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            G_Life += 1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            print(G_Life);
        }
    }

    public void ChangeLevelOne()
    {
        SceneManager.LoadScene("Demo");
        G_Scene = 1;
    }

    public static void ChangeLevelTwo()
    {
        SceneManager.LoadScene("Level_zero");
        G_Scene = 2;
    }

    public static void ChangeMainManu()
    {
        SceneManager.LoadScene("Main_Mune");
        G_Scene = 0;
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
