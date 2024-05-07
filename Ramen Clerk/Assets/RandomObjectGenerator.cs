using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class RandomObjectGenerator : MonoBehaviour
{
    public List<GameObject> ToolList;
    public List<Vector3> spawnPositions;

    void Start()
    {

        List<GameObject> tools = ToolList.OrderBy(x => Guid.NewGuid()).ToList();
        spawnPositions = spawnPositions.OrderBy(x => Guid.NewGuid()).ToList();
        
        int count = tools.Count;

        for (int i = 0; i < count; i++)
        {
            
            GameObject newTool = Instantiate(tools[i], spawnPositions[i], Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}