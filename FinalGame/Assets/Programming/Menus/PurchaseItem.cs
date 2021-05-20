/****************
* Name: Andrew Dahlman-Oeth
* Date:
* Desc:
****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseItem : MonoBehaviour
{
    public string rarity;
    public GameObject title;
    public GameObject description;
    public GameObject sprite;

    private StaticVars StaticVars;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem()
    {
        if(rarity == "Common")
        {
            StaticVars.TotalGold -= 10;
        }
        if(rarity == "Rare")
        {
            StaticVars.TotalGold -= 20;
        }
        if(rarity == "Legendary")
        {
            StaticVars.TotalGold -= 50;
        }
    }
}
