using UnityEngine;
using UnityEngine.EventSystems;

// Rigidbodyコンポーネントがアタッチされていなければアタッチします
[RequireComponent(typeof(Rigidbody))]
// インターフェースを実装します
public class StockFood : MonoBehaviour, IPointerClickHandler
{
    Rigidbody rigidBody;

    // インスペクタで調整が可能になります
    public Vector3 force = new Vector3(0, 0, 10);

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // ここに、クリックした時に実行したいコードを記述します。
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("クリックイベントが発生");
        // 瞬発的に力を加えます（オブジェクトの質量の無視の設定です）
        rigidBody.AddForce(force, ForceMode.VelocityChange);
    }
}