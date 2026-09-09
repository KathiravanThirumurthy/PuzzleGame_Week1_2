using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefab;
    [SerializeField] private int boxCount = 3;
    [SerializeField] private float spacing = 2f;

    private void Start()
    {

         Instantiate(
                boxPrefab,
                new Vector3(0, 0.5f, 2),
                Quaternion.identity
            );

        
    /*    for (int i = 0; i < boxCount; i++)
        {
            Vector3 position =
                new Vector3(i * spacing, 0.5f, 2);

            Instantiate(
                boxPrefab,
                position,
                Quaternion.identity
            );
        }*/
    }
   
}