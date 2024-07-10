using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private float speed = 5.0f;
    [SerializeField] Transform[] targets;
    private int currentTargetIndex = 0;
 
    void Update()
    {
        if (currentTargetIndex < targets.Length)
        {
            Transform currentTarget = targets[currentTargetIndex];
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

            // Check if the current target has been reached
            if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
            {
                // Move to the next target
                currentTargetIndex++;
            }
        }
    }
}
