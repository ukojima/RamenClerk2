using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodChecker : MonoBehaviour
{
    public List<string> FoodList;
    public string OrderFood;   
    public TextMeshProUGUI orderText; 
    public string customer;


    void NewOrder()
    {
        int randomIndex = Random.Range(0, FoodList.Count);
        OrderFood = FoodList[randomIndex];
        Debug.Log("注文は" + OrderFood);
        
        if (orderText != null)
        {
            orderText.text = /*"注文は" +*/ OrderFood;
        }
        else
        {
            Debug.Log("アタッチされてない");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(customer))
        {
            NewOrder();
        }

        if (other.CompareTag(OrderFood ))
        {
            Debug.Log(OrderFood + "が正しく提供されました。");
            Destroy(other.gameObject);
            NewOrder();
            GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("customer");
            foreach(GameObject obj in tagobjs)
            {
                Destroy(obj);
            }
        }
        
        else
        {
            Debug.Log(other.gameObject.tag + "は間違っています。");
        }
    }
}
