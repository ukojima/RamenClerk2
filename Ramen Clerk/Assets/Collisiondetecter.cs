using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetecter : MonoBehaviour
{
    public CollisionGenerater cg;

    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("Collision detected");
       // Debug.Log("Collision tag" + collision.gameObject.tag);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            Instantiate(
            cg.newFood("soup", "kaeshi"));

        }
    }
}
