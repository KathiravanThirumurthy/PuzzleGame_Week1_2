using UnityEngine;
using UnityEngine.InputSystem.XInput;

namespace Day4
{
    

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private float xinput;
    private float zinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Key is pressed Once
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                Debug.Log("KeyPAd Enter Pressed!");
            }

       // Key is held Every frame
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("Moving Right...");
            }
        // Key is released Once
            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("Stopped Moving Right");
            }

            Move();
            Jump();
    }

        private void Move()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0, vertical);
            transform.position += direction.normalized * moveSpeed * Time.deltaTime;
           /* Vector3 temp=transform.position;
            xinput=Input.GetAxis("Horizontal");
            temp.x+=xinput * moveSpeed *Time.deltaTime;
            transform.position=temp;*/ 
         }
         private void Jump()
         {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Jumping...");
            }
         }
}

}

