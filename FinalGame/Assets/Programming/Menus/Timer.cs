using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    public TMP_Text textTimer;

    private float timer = 0.0f;
    private bool isTimer = false;

    private void Awake()
    {
        instance = this;
    }


    void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }
    }

    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60.0f);
        textTimer.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }

    public void ResetTimer()
    {
        timer = 0.0f;
    }

}
