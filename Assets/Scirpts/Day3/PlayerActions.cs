using NUnit.Framework;
using Unity.Scripting.LifecycleManagement;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    int a=10;
    int b=20;
    int x=15;
    int y=20;
    private int sum;
    private bool isAlive=false;
    private int score=0;
    private int health=100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        // calling or invoking function 
        Attack(10);
        Attack(50);
        Attack(100);
        sum=add(a,b);
        Debug.Log("Sum :"+sum);
        isAlive=toggleevent(isAlive);
        Debug.Log("isAlive"+ isAlive);
        score=calculateScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

// function declaration
    void Attack(int power)
    {
        Debug.Log("Player Attacked value =" + power);
        health=health-power;
        Debug.Log(health);
        
    }

    int add(int x , int y)
    {
        int c=x+y;
        return c;
       
    }


    bool toggleevent(bool isAlive)
    {
        
        return !isAlive;
    }
    
    int calculateScore(int score)
    {
        int point=score+5;
        return point;
    }
    
}


/*
function types 
1.function with no parameters and no return value
2.function with parameters and no return value
3.function with return value

piece of reusable code

// function delcaration
adding()
{
    int sum=a+b;
    return sum;
}
// calling or invoking function
adding();


function passing parameters
int a=10;
int b=20;
//invoking
int result=add(a,b);

int add(int x,int y)
{
   int sum=x+y;
   return sum;
}


*/