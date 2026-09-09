using UnityEngine;


namespace Day5
{
public class KeyInteraction : MonoBehaviour
{
   [SerializeField] 
   private GameManager gameManager;

        private void OnMouseDown()
        {
            CollectKey();
        }

        private void CollectKey()
        {
           gameManager.hasKey = true;

            Debug.Log("Key Collected!");

            gameObject.SetActive(false);
        }
}

}