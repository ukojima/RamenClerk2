using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject npcPrefab; // NPCのプレハブ
    public int maxNPCCount = 10; // 最大NPC数
    public float spawnInterval = 1.0f; // 生成間隔
    public Vector3 spawnArea = new Vector3(10, 0, 10); // 生成エリア

    private List<GameObject> npcs = new List<GameObject>();

    void Start()
    {
        StartCoroutine(SpawnNPCs());
    }

    IEnumerator SpawnNPCs()
    {
        while (true)
        {
            if (npcs.Count < maxNPCCount)
            {
                Vector3 spawnPosition = new Vector3(
                    Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
                    spawnArea.y,
                    Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
                );

                GameObject npc = Instantiate(npcPrefab, spawnPosition, Quaternion.identity);
                npcs.Add(npc);
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void RemoveNPC(GameObject npc)
    {
        npcs.Remove(npc);
        Destroy(npc);
    }

    void Update()
    {
        // デバッグ用：キーボードのRキーを押すとランダムにNPCを削除
        if (Input.GetKeyDown(KeyCode.R) && npcs.Count > 0)
        {
            int randomIndex = Random.Range(0, npcs.Count);
            RemoveNPC(npcs[randomIndex]);
        }
    }
}
