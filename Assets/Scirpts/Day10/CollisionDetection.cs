using UnityEngine;

namespace Day10
{
public class CollisionDetection : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
            {
              //  Debug.Log("Collision with: " + collision.gameObject.name);

                if (collision.gameObject.CompareTag("Box"))
                {
                    Debug.Log("BOX FOUND!");

                    Rigidbody boxRb =
                        collision.gameObject.GetComponent<Rigidbody>();

                  //  Debug.Log("Box Rigidbody: " + boxRb);

                    boxRb.AddForce(
                        transform.forward * 2f,
                        ForceMode.Impulse
                    );

                 //   Debug.Log("FORCE APPLIED!");
                }
            }
   
}
}
