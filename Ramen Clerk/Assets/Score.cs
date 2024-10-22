using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI Scorebord;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScoreBoard();  // 初期スコアを表示
    }

    public void ScoreCount(int points)
    {
        score += points;
        UpdateScoreBoard();  // スコアを更新するたびに表示を更新
    }

    // スコアボードを更新するメソッド
    void UpdateScoreBoard()
    {
        Scorebord.text = "Score: " + score.ToString();  // ToString()を正しく使用
    }
}
