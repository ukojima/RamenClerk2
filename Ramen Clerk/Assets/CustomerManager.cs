using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private float speed = 5.0f;
    [SerializeField] Transform[] targets;
    private int currentTargetIndex = 0;
    private bool isMoving = true; 

    [SerializeField] private int maxMoves = 5; // 移動回数
    private int moveCount = 0; 

    void CustomerMover()
    {
        if (isMoving && currentTargetIndex < targets.Length && moveCount < maxMoves) // isMovingフラグと移動回数をチェック
        {
            Transform currentTarget = targets[currentTargetIndex];
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

            // Check if the current target has been reached
            if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
            {
                // Move to the next target
                currentTargetIndex++;
                moveCount++; // 移動回数をカウント

                // If the last target is reached, reset to the first target if under max moves
                if (currentTargetIndex >= targets.Length)
                {
                    currentTargetIndex = 0; // 最初のターゲットに戻る
                }
            }
        }
        else if (moveCount >= maxMoves)
        {
            isMoving = false; // 最大移動回数に達したら停止
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
