using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    float speed = 1.4f;

    double mana = 15.5;

    int health = 100;

    string name = "Hello";

    bool isDead = true;

    // component
    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource audioSource;
    private Animator anim;

    private void Start() {

        
        float a = 10;
        float b = 5;

        print("Hello world");

        // Debug.Log("Debugging");

        float c = addingTwoNumbers(a, b);
        Debug.Log(c);

        // if else
        if (health < 0 ){
            // ded

        }else if (health < 50){
            // almost ded
        }else{

        }

        // switch
        switch (health)
        {
            case 100:
                break;
            case 50:
                break;
            case 0:
                break;
            default:
                break;
        }
        
        // loop
        for (int i=0; i < 10; i++){
            // Debug.Log("i is " + i);
        }

        //Coroutine
        StartCoroutine(ExecuteSomething());

        StartCoroutine("ExecuteSomething");
        StopCoroutine("ExecuteSomething");

        // object
        Player warrior = new Player(100, 5, "warrior");
        warrior.info();
        // warrior.setHealth(20);
        // Debug.Log(warrior.getHealth());
        // Debug.Log(warrior.Power);
        warrior.Attack();

        Warrior warrior2 = new Warrior(100, 5, "warrior2");
        warrior2.Health = 20;
        warrior2.info();
        warrior2.ThrowAxe();
        warrior2.Attack();

        // get component

        myBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
   
    }
    
    float addingTwoNumbers(float a, float b){
            // Debug.Log("Printed from function");
            // Debug.Log("Adding a and b is " + (a+b));
            return (a+b);
            
        }

    IEnumerator ExecuteSomething(){
        yield return new WaitForSeconds(2f);

        Debug.Log("Something is executed");

        yield return new WaitForSeconds(2f);

        Debug.Log("More is executed");

    }

}
