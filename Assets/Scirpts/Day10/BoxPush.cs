using UnityEngine;

namespace Day10
{
    

public class BoxPush : MonoBehaviour
{
    [SerializeField] private float pushForce = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        Vector3 direction = transform.position - collision.transform.position;

        direction.y = 0;

        rb.AddForce(
            direction.normalized * pushForce,
            ForceMode.Impulse
        );
    }
}

}