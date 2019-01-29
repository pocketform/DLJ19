using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    public const int hp_points = 5;
    public const int armor_points = 10;

    MyEnemy MyFirstEnemy = new MyEnemy(hp_points);

    //Boss MyFirstBoss = new Boss(hp_points);
    Boss MyFirstBoss = new Boss(hp_points, armor_points);

    // Start is called before the first frame update
    void Start()
    {
        //MyFirstEnemy.set_hp(25);
        //MyFirstEnemy.set_score(11);

        //Debug.Log("The hp of My first Enemy is " + MyFirstEnemy.get_hp());
        //Debug.Log("The score of My first Enemy is " + MyFirstEnemy.get_score());


        MyFirstBoss.set_hp(55);
        MyFirstBoss.set_score(21);
        //MyFirstBoss.set_armor(735);

        Debug.Log("The hp of My first Enemy is " + MyFirstBoss.get_hp());
        Debug.Log("The score of My first Enemy is " + MyFirstBoss.get_score());
        Debug.Log("The armor of My first Enemy is " + MyFirstBoss.get_armor());
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
