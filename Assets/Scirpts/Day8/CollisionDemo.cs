using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* private void OnCollisionEnter(Collision collision)
   {
       Debug.Log("Collision with: " + collision.gameObject.name);
   }*/

    /*    private void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.CompareTag("Box"))
        {
            Debug.Log("Player touched the Box!");
                        Debug.Log("Object: " +
                collision.gameObject.name);

            Debug.Log("Contact Count: " +
                collision.contactCount);

        }
                }*/
       private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("CollisionEnter with: " + collision.gameObject.name);
            if (collision.gameObject.CompareTag("Box"))
            {
                Rigidbody boxRb =
                    collision.gameObject.GetComponent<Rigidbody>();

                boxRb.AddForce(
                    transform.forward * 5f,
                    ForceMode.Impulse
                );
            }
        }

        private void OnCollisionStay(Collision collision)
        {
             Debug.Log("CollisionStay with: " + collision.gameObject.name);
            if (collision.gameObject.CompareTag("Box"))
            {
                Rigidbody boxRb =
                    collision.gameObject.GetComponent<Rigidbody>();

                boxRb.AddForce(
                    transform.forward * 5f,
                    ForceMode.Force
                );
            }
        }



}
