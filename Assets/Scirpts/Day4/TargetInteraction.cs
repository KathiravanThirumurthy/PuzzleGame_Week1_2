using UnityEngine;

namespace Day4
{
    

public class TargetInteraction : MonoBehaviour
{
    private int targetCount = 0;
    private void OnMouseDown()
    {
        Interaction();
    }
    void Interaction()
    {
        targetCount++;
        Debug.Log("Target Count: " + targetCount);
        gameObject.SetActive(false);
    }

}

}

