using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveCount : MonoBehaviour
{
    public TMP_Text waveDisplay;

    void Update()
    {
        waveDisplay.text = string.Format("Wave: {00}", StaticVars.TotalWaves);
    }
}
