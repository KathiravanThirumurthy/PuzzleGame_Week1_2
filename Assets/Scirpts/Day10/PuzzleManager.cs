using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{

  [Header("Win UI")] 
  [SerializeField] private GameObject winText;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
    public void PuzzleCompleted()
    {
        Debug.Log("🎉 PUZZLE COMPLETE!");
         winText.SetActive(true);
    }
}
