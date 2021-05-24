/****************
* Name: Andrew Dahlman-Oeth
* Date:
* Desc:
****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PurchaseItem : MonoBehaviour
{
    public string rarity;
    public TMP_Text itemPrice;
    public GameObject title;
    public GameObject description;
    public GameObject sprite;
    public int commonPrice = 10;
    public int rarePrice = 20;
    public int legendaryPrice = 50;


    private StaticVars StaticVars;
    

    // Start is called before the first frame update
    void Start()
    {
        if(rarity == "Common")
        {
            itemPrice.text = string.Format("{00}G", commonPrice);
        }
        if(rarity == "Rare")
        {
            itemPrice.text = string.Format("{00}G", rarePrice);
        }
        if(rarity == "Legendary")
        {
            itemPrice.text = string.Format("{00}G", legendaryPrice);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem()
    {
        
        if(rarity == "Common")
        {
            if(StaticVars.TotalGold >= commonPrice)
            {
                StaticVars.TotalGold -= commonPrice;
            }
        }

        if(rarity == "Rare")
        {
            if(StaticVars.TotalGold >= rarePrice)
            {
                StaticVars.TotalGold -= rarePrice;
            } 
        }

        if(rarity == "Legendary")
        {
            if(StaticVars.TotalGold >= legendaryPrice)
            {
                StaticVars.TotalGold -= legendaryPrice;
            }   
        }
    }
}
