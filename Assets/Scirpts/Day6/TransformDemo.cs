using UnityEngine;

namespace Day6
{
    

public class TransformDemo : MonoBehaviour
{
    private Rigidbody rbd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);
        rbd=GetComponent<Rigidbody>();
        Debug.Log(rbd);
      //  rbd.useGravity=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}

