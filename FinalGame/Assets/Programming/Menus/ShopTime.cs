using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopTime : MonoBehaviour
{
    public static ShopTime instance;

    //public TMP_Text textTimer;

    private float timer = 0.0f;
    private bool isTimer = false;
    private GameController GameController;

    
    private void Awake()
    {
        instance = this;
        GameController = GetComponent<GameController>();
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
        int seconds = 60 - (Mathf.FloorToInt(timer - minutes * 60.0f));
        //textTimer.text = string.Format("{00}", seconds);
        if(seconds == 1)
        {
            print("Shop Time");
            ShopTimerDone();
        }
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

    public void ShopTimerDone()
    {
        GameController.isGoing = false;

    }

}
