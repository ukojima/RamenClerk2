using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodChecker : MonoBehaviour
{
    public List<string> FoodList;
    public string OrderFood;   
    public TextMeshProUGUI orderText; 

    void Start()
    {
        NewOrder();
    }

    void NewOrder()
    {
        int randomIndex = Random.Range(0, FoodList.Count);
        OrderFood = FoodList[randomIndex];
        Debug.Log("注文は" + OrderFood);
        
        if (orderText != null)
        {
            orderText.text = "注文は" + OrderFood;
        }
        else
        {
            Debug.Log("アタッチされてない");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == OrderFood)
        {
            Debug.Log(OrderFood + "が正しく提供されました。");
            Destroy(other.gameObject);
            NewOrder(); 
        }
        else
        {
            Debug.Log(other.gameObject.tag + "は間違っています。");
        }
    }
}
