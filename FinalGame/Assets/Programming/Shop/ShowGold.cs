/****************
* Name: Andrew Dahlman-Oeth
* Date:
* Desc:
****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowGold : MonoBehaviour
{
    public TMP_Text goldText;

    private StaticVars StaticVars;
    // Start is called before the first frame update
    void Start()
    {
        goldText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = string.Format("Gold: {000}", StaticVars.TotalGold);
    }
}
