using UnityEngine;

namespace Day6
{

public class GameManager : MonoBehaviour
{
    public PlayerInfo playerInfo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //playerInfo = GetComponent<PlayerInfo>();
       Debug.Log("Player: " + playerInfo.playerName);
        Debug.Log("Health: " + playerInfo.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
