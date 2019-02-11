using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraPosition;

    public float minX = -5;
    public float maxX = 10;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //No limit
        //cameraPosition = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        //method 01
        //if (cameraPosition.x < minX)
        //{
        //    cameraPosition.x = minX;
        //}
        //if (cameraPosition.x > maxX)
        //{
        //    cameraPosition.x = maxX;
        //}
        //cameraPosition = new Vector3(cameraPosition.x, player.transform.position.y, -10);

        //method 02
        //float positionX;
        //positionX = player.transform.position.x;
        //positionX = Mathf.Clamp(positionX, minX, maxX);
        //cameraPosition = new Vector3(positionX, player.transform.position.y, -10);

        //method 03
        cameraPosition = new Vector3(Mathf.Clamp(player.transform.position.x,minX,maxX), player.transform.position.y, -10);
        this.gameObject.transform.position = cameraPosition;
    }
}
