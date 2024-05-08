using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    public string material1;
    public string marerial2; 
    public GameObject RamenSoup;

    void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("soup") || collision.gameObject.CompareTag("kaeshi"))
        {
            Vector3 spawnPositions = collision.contacts[0].point;
            Instantiate(RamenSoup, spawnPositions, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
