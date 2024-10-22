using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed = 10f;
    private float cameraSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
     
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * moveSpeed);
        }
        
                if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * moveSpeed);
        }
        
                if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * moveSpeed);
        }
        
                if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * moveSpeed);
        }

        
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W) ||
            Input.GetKeyUp(KeyCode.S) ||
            Input.GetKeyUp(KeyCode.D) ||
            Input.GetKeyUp(KeyCode.A))
         {
            rb.velocity = Vector3.zero;
        }

        if (Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Mouse X") * cameraSpeed;
            if(Mathf.Abs(x) > 0.1f)
            {
                transform.RotateAround(transform.position, Vector3.up, x);
            }
           
        }

    }

    
}
