using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
   
        private void OnCollisionEnter(Collision collision)
            {
              //  Debug.Log("Collision with: " + collision.gameObject.name);

                if (collision.gameObject.CompareTag("Box"))
                {
                  //  Debug.Log("BOX FOUND!");

                    Rigidbody boxRb =
                        collision.gameObject.GetComponent<Rigidbody>();

                  //  Debug.Log("Box Rigidbody: " + boxRb);

                    boxRb.AddForce(
                        transform.forward * 5f,
                        ForceMode.Impulse
                    );

                 //   Debug.Log("FORCE APPLIED!");
                }
            }
      private void OnCollisionStay(Collision collision)
            {
                if (collision.gameObject.CompareTag("Box"))
                {
                    Debug.Log("Player staying with Box");

                    Rigidbody boxRb =
                        collision.gameObject.GetComponent<Rigidbody>();

                    boxRb.AddForce(
                        transform.forward * 5f,
                        ForceMode.Force
                    );
                }
            }

            private void OnCollisionExit(Collision collision)
            {
                if (collision.gameObject.CompareTag("Box"))
                {
                    Debug.Log("Player exited Box");
                }
            }



}
