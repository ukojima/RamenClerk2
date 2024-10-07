using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodChecker : MonoBehaviour
{
    public CustomerOrder co;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("customer"))
        {
            return;
        }

        if(other.CompareTag(co.OrderFood))
        {
            Debug.Log("提供が完了した");
            Destroy(other.gameObject);
        }
    }
    
}
