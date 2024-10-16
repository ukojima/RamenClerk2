using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerOrder : MonoBehaviour
{
    public List<string> FoodList;
    public string OrderFood;   
    public TextMeshProUGUI orderText; 
    public FoodChecker fc;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("counter"))
        {
            NewOrder();
            orderText.text =/* "注文は" + */OrderFood;
        }
        
    }

    void NewOrder()
    {
        int randomIndex = Random.Range(0, FoodList.Count);
        OrderFood = FoodList[randomIndex];
        Debug.Log("注文は" + OrderFood);
    }

}