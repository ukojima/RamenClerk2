using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{
    public GameObject[] Customer;
    private float time;
    private int number;
    int x =188;
    int y =1;
    int z = 13;

    // Use this for initialization
    void Start () 
    {
        time = 1.0f;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0.0f)
        {
            time = 1.0f;
            number = Random.Range(0, 10);
            if(number == 0)
            {
                Instantiate (Customer[0], new Vector3(x,y,z), Quaternion.identity);
            }
        }
        
    }

}