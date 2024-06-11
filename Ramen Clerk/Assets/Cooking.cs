using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    public string material1;
    public string material2; 
    public GameObject RamenSoup;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        Debug.Log("Collision tag: " + collision.gameObject.tag);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 何もしない
    }
}
