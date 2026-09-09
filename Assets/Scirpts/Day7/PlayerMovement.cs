using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 10f;

    void Update()
    {
        // 1. Get input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // 2. Create direction
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // 3. Do nothing if there is no input
        if (direction == Vector3.zero)
            return;

        // 4. Find the direction we want to face
        Quaternion targetRotation =
            Quaternion.LookRotation(direction);

        // 5. Smoothly rotate toward that direction
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime 
        );

        // 6. Check how closely we are facing the target
        float angle = Quaternion.Angle(
            transform.rotation,
            targetRotation
        );

        // 7. Move only when mostly facing the target
        if (angle < 5f)
        {
            transform.position +=
                transform.forward *
                moveSpeed *
                Time.deltaTime;
        }
    }
}

