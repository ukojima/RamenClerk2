using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使用します

public class Stock : MonoBehaviour  //appearという名前のクラスを定義します
{
    public GameObject cubePrefab;// 出現させるオブジェクトを保存しておくGameObejct型の変数

    public Vector3 potision;//出てくるオブジェクトの場所を決めます（宣言）


    private void Start()
    {
        Button objectAppeaButton = GetComponent<Button>();//ボタン要素を取得します

        objectAppeaButton.onClick.AddListener(SpawnCubeAtPosition);//objectAppearButtonがボタンを押されたときに、SpawnCubeAtPositionという名前の関数を呼びます
    }


    public void SpawnCubeAtPosition()//SpawnCubeAtPositionという名前の関数です
    {

       Instantiate(cubePrefab, potision, Quaternion.identity); // 変数cubePrefabに保存されたオブジェクトを変数positionの位置に出現させます。

    }
}