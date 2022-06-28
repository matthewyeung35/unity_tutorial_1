using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// warrior class
public class Warrior : Player
{

    public Warrior(int health, int power, string name){
        Health = health;
        Power = power;
        Name = name;
    }

    public void ThrowAxe(){
        Debug.Log(Name + " is thorwing axe");
    }

    public override void Attack(){
         Debug.Log(Name + " is attacking with axe");    
    }
}
