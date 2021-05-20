using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldCounter : MonoBehaviour
{
    public static GoldCounter instance;
    public TMP_Text textTimer;
    public int Gold = 0;

    private void Awake()
    {
        instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        textTimer.text = string.Format("Gold: {000}", Gold);
    }
}
