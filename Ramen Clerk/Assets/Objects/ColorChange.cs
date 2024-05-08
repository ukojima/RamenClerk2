using System.Collections;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color startcolor = Color.yellow;
    public Color middlecolor = Color.green;
    public Color endcolor = Color.blue;
    public float time = 2f; // 変化までの待機時間
    public float time2 = 4f;
     public float time3 = 6f;
    private bool condition = false; // 変化条件

    void OnCollisionStay(Collision collision)
    {
        // 衝突したオブジェクトがCube1タグを持っているか確認
        if (collision.gameObject.CompareTag("Oyu"))
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

        // 条件が満たされた後、time秒待機
        yield return new WaitForSeconds(time);
        
        // endColorに変化
        gameObject.GetComponent<Renderer>().material.color = startcolor;
        
        //time2秒待機
        yield return new WaitForSeconds(time2);
        
        // middleColorに変化
        gameObject.GetComponent<Renderer>().material.color = middlecolor;

        //time3秒待機
        yield return new WaitForSeconds(time3);
        
        // middleColorに変化
        gameObject.GetComponent<Renderer>().material.color = endcolor;

    }
}
