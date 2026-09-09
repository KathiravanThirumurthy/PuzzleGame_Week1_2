using UnityEngine;

public class SprintMovement : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 2f;
    [SerializeField] private float sprintSpeed = 10f;
    [SerializeField] private float rotationSpeed = 10f;

    private void Update()
    {
        // Get input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // No input
        if (direction == Vector3.zero)
            return;

        // Find target rotation
        Quaternion targetRotation =
            Quaternion.LookRotation(direction);

        // Rotate toward direction
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            rotationSpeed * 100f * Time.deltaTime
        );

        // Choose speed
        float currentSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = normalSpeed;
        }

        // Move only when facing the target
        float angle = Quaternion.Angle(
            transform.rotation,
            targetRotation
        );

        if (angle < 5f)
        {
            transform.position +=
                transform.forward *
                currentSpeed *
                Time.deltaTime;
        }
    }

}
