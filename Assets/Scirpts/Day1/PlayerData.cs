using UnityEngine;

public class PlayerData : MonoBehaviour
{

[SerializeField]
private string playerName = "Hero";
public int score = 100;
public float speed = 5.5f;
public bool isAlive = true;

    void Awake()
    {
        Debug.Log("AWake Started");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(playerName);
        Debug.Log(score);
        Debug.Log(speed);
        Debug.Log(isAlive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

