using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountTime : MonoBehaviour
{
    public float countdownMinutes = 3;
    public float countdownSeconds;
    public TextMeshProUGUI timeText; // インスペクタで直接アタッチ

    private void Start()
    {
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0)
        {
            // 0秒になったときの処理
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
