using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticVars.TotalGold = 0;
        StaticVars.TimePassed = 0f;
        StaticVars.TurnSpeed = 100f;
        StaticVars.TotalWaves = 0;
        StaticVars.TotalAccelerationAmount = 5f;
        StaticVars.TotalDecelerationAmount = 10f;
    }   
}

