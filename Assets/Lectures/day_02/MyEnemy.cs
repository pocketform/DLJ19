using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy
{
    public MyEnemy(int hps)
    {
        this.hp = hps;
    }

    public void set_hp( int set_hp) { this.hp = set_hp; }
    public void set_score(int set_score) { this.score = set_score; }

    public int get_hp() { return this.hp; }
    public int get_score() { return this.score; }

    private int hp;
    private int score;
}

//public class MyEnemy : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
