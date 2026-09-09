using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        // without keyboard interaction moving objects
       // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
       /*
       with key interaction wsad moving objects
       float horizontal =
            Input.GetAxisRaw("Horizontal");

        float vertical =
            Input.GetAxisRaw("Vertical");

        Vector3 direction =
            new Vector3(horizontal, 0, vertical);

        transform.position +=
            direction.normalized *
            moveSpeed *
            Time.deltaTime;
        */

        // rotatiing the object and facing the direction
        float horizontal =  Input.GetAxisRaw("Horizontal");

        float vertical =  Input.GetAxisRaw("Vertical");

        Vector3 direction =  new Vector3(horizontal, 0, vertical);
        

        if (direction != Vector3.zero)
        {
            // 1. Move
            transform.position +=
                direction.normalized *
                moveSpeed *
                Time.deltaTime;
            //2. Face movement direction
            transform.forward = direction;
        }
    }
}

/*

What is transform.forward?

Every GameObject in Unity has a Transform.

The Transform has three important directions:

transform.right    → X direction
transform.up       → Y direction
transform.forward  → Z direction


*/


