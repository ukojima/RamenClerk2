using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodChecker : MonoBehaviour
{
    public List<string> FoodList; //メニューのリスト
    public string OrderFood;

    void Start()
    {
        int randomIndex = Random.Range(0, FoodList.Count);
        OrderFood = FoodList[randomIndex];
        Debug.Log("注文は" + OrderFood);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == OrderFood)
        {
            Debug.Log(OrderFood + "が正しく提供されました。");
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log(other.gameObject.tag + "は間違っています。");
        }
    }
}
