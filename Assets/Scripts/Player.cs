using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// player class
public class Player
{

    private int _health;
    public int Health{
        get { 
            return _health;
        }
        set {
            _health = value;
        }
    }

    private int _power;
    public int Power{
        get { 
            return _power;
        }
        set {
            _power = value;
        }
    }
    
    private string _name;
    public string Name{
        get { 
            return _name;
        }
        set {
            _name = value;
        }
    }

    public Player (){}

    public Player(int health, int power, string name){

        Health = health;
        Power = power;
        Name = name;
        
    }

    public void info(){
        Debug.Log("Health is " + Health);
        Debug.Log("Power is " + Power);
        Debug.Log("Name is " + Name);    
    }

    public virtual void Attack(){
        Debug.Log(Name + " is shooting fire");    
    }


    // other method of setter and getter

    // public void setHealth(int health){
    //     this.health = health;
    // }
    // public int getHealth(){
    //     return this.health;
    // }
    
}
