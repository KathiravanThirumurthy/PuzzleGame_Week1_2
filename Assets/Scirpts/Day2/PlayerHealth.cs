using System.Collections;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private bool isAlive=true;
    public int playerHealth = 90;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(isAlive)
        {
            Debug.Log("The Player is Alive");
        }else
        {
            Debug.Log("The Player is dead");
        }


        if (playerHealth <= 100 && playerHealth > 80)
        {
            Debug.Log("Health is Good");
        }
        else if (playerHealth <= 80 && playerHealth > 50)
        {
            Debug.Log("Player Got Damaged");
        }
        else if (playerHealth <= 50 && playerHealth > 10)
        {
            Debug.Log("Need Health");
        }
        else if (playerHealth <= 10)
        {
            Debug.Log("Player is Dead");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



