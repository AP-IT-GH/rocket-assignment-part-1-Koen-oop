using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float acceleration = 5.0f;
    private float horizontalInput;
    private float verticalInput;
    private float horizontalInput2;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb= GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput2 = Input.GetAxis("Vertical");
        verticalInput = Input.GetAxis("Jump");
        //beweging links en rechts/ voor en achter
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput2);
        //beweging naat boven
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0,acceleration, 0);
        }
    }
}
