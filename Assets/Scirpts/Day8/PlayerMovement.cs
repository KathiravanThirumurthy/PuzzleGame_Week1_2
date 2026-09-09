using UnityEngine;

namespace Day8
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float normalSpeed = 2f;
        [SerializeField] private float sprintSpeed = 10f;

        [Header("Rotation")]
        [SerializeField] private float rotationSpeed = 10f;

        private Vector3 direction;
        private Rigidbody rb;
        private float currentSpeed;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            // Get input
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            direction = new Vector3(horizontal, 0, vertical);

            // Choose speed
            if (Input.GetKey(KeyCode.LeftShift))
            {
                currentSpeed = sprintSpeed;
            }
            else
            {
                currentSpeed = normalSpeed;
            }
        }

        private void FixedUpdate()
{
    if (direction == Vector3.zero)
        return;

    Quaternion targetRotation =
        Quaternion.LookRotation(direction);

    // Rotate
    rb.MoveRotation(
        Quaternion.RotateTowards(
            rb.rotation,
            targetRotation,
            rotationSpeed * 100f * Time.fixedDeltaTime
        )
    );

    // Move
    Vector3 movement =
        transform.forward *
        currentSpeed *
        Time.fixedDeltaTime;

    rb.MovePosition(
        rb.position + movement
    );
}
    }
}