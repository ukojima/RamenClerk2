using System.Collections;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color startColor = Color.red;
    public Color endColor = Color.blue;
    public float timeDelay = 2f; // 変化までの待機時間
    public float TIme = 4f;
    private bool condition = false; // 変化条件

    void OnCollisionStay(Collision collision)
    {
        // 衝突したオブジェクトがCube1タグを持っているか確認
        if (collision.gameObject.CompareTag("Cube1"))
        {
            condition = true; // 条件を満たす
        }
    }

    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        // 条件が満たされるまで待機
        yield return new WaitUntil(() => condition == true);

        // 条件が満たされた後、timeDelay秒待機
        yield return new WaitForSeconds(timeDelay);
        
        // endColorに変化
        gameObject.GetComponent<Renderer>().material.color = endColor;

    }
}
