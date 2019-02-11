using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Follow : MonoBehaviour
{    
    public float moveDistance = 1f;
    public Transform playerPosition;
    public float speed = 1f;
    public float maxSpeed = 2f;
    public float minSpeed = 0.001f;
    public float maxDistance = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follow the player
        //gameObject.transform.position = playerPosition.position;


        //Distance follow player
        float distance = Vector2.Distance(new Vector2(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y), new Vector2(playerPosition.position.x, playerPosition.position.y));
        Vector3 followPosition = gameObject.GetComponent<Transform>().position;

        if (distance > moveDistance)//follow distance
        {
            followPosition = Vector3.Lerp(gameObject.GetComponent<Transform>().position, playerPosition.position, speed);
        }
        if (distance > maxDistance)//max speed distance
        {
            followPosition = Vector3.Lerp(gameObject.GetComponent<Transform>().position, playerPosition.position, maxSpeed);
        }

        gameObject.GetComponent<Transform>().position = followPosition;
    }
}
