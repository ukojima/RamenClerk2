using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private float speed = 5.0f;
    [SerializeField] Transform[] targets;
    private int currentTargetIndex = 0;
    private bool isMoving = true; // フラグを追加

    void CustomerMover()
    {
        if (isMoving && currentTargetIndex < targets.Length) // isMoving フラグをチェック
        {
            Transform currentTarget = targets[currentTargetIndex];
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

            // Check if the current target has been reached
            if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
            {
                // Move to the next 
                currentTargetIndex++;
            }
        }

        if (Input.GetKey(KeyCode.P))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("customer"))
        {
            isMoving = false; // 衝突範囲に入ったら停止
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("customer"))
        {
            isMoving = true; // 衝突範囲から出たら再開
        }
    }

    void Update()
    {
        CustomerMover();
    }
}
