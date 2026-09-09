using UnityEngine;

namespace Day5
{

public class DoorInteraction : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

        private void OnMouseDown()
        {
            TryOpenDoor();
        }

        private void TryOpenDoor()
        {
            if (gameManager.hasKey)
            {
                OpenDoor();
            }
            else
            {
                Debug.Log("You need a key!");
            }
        }

        private void OpenDoor()
        {
            Debug.Log("Door Opened!");

            gameObject.SetActive(false);
        }
}

}