using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldDisplay : MonoBehaviour
{
    //public TMP_Text textTimer;

    private StaticVars StaticVars;


    private void Awake()
    {
        StaticVars = GetComponent<StaticVars>();
    }

    // Start is called before the first frame update
    void Start()
    {
        print(StaticVars.TotalGold);
    }

}
