using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMune : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevelOne()
    {
        SceneManager.LoadScene("Demo");
        CrossSceneDate.G_Scene = 1;
    }

    public void ChangeLevelTwo()
    {

    }

    public void ChangeMainManu()
    {

    }
}
