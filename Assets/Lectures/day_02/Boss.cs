using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MyEnemy
{

    public Boss(int hps) : base(hps)
    {
        this.set_hp(hps);
    }

    public Boss(int hps, int armors) : base(hps)
    {
        this.set_hp(hps);
        this.set_armor(armors);
    }

    public int get_armor() { return this.armor; }
    public void set_armor(int armors) { this.armor = armors; }

    private int armor;
}





//public class Boss : MonoBehaviour
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
