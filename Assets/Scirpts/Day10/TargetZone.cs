using UnityEngine;

namespace Day10
{
    

public class TargetZone : MonoBehaviour
{
    [SerializeField] private PuzzleManager puzzleManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            puzzleManager.PuzzleCompleted();
        }
    }
}

}