using UnityEngine;

public class PuzzleTile : MonoBehaviour
{
    
    [SerializeField] private bool isRed = true;

    private Renderer tileRenderer;

    private void Start()
    {
        tileRenderer = GetComponent<Renderer>();
        UpdateColor();
    }

    private void OnMouseDown()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        isRed = !isRed;

        UpdateColor();

        Debug.Log("Tile clicked!");
    }

    private void UpdateColor()
    {
        if (isRed)
        {
            tileRenderer.material.color = Color.red;
        }
        else
        {
            tileRenderer.material.color = Color.blue;
        }
    }
}
