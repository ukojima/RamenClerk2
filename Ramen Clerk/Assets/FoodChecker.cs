using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodChecker : MonoBehaviour
{
    public CustomerOrder co;
    public Score scoreManager;  // 'ct' を 'scoreManager' に変更（わかりやすさのため）

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("customer"))
        {
            return;
        }

        if (other.CompareTag(co.OrderFood))
        {
            Debug.Log("提供が完了した");
            Destroy(other.gameObject);

            scoreManager.ScoreCount(1);  // 1点加算
        }
    }
}
