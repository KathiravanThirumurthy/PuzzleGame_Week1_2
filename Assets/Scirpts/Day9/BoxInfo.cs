using UnityEngine;

public class BoxInfo : MonoBehaviour
{
    
    [SerializeField] private string boxID = "BOX_01";

    public string GetBoxID()
    {
        return boxID;
    }
}
