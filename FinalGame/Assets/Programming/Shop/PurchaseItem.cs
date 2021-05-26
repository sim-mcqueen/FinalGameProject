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
    public TMP_Text title;
    public GameObject description;
    public GameObject sprite;
    public int commonPrice = 10;
    public int rarePrice = 20;
    public int legendaryPrice = 50;


    private StaticVars StaticVars;
    private SpriteRenderer sp;

    Color commonColor = new Color(0.6f, 0.6f, 0.6f, 1f);
    Color rareColor = new Color(94f / 255f, 204f / 255f, 255f / 255f, 1f);
    Color legendaryColor = new Color(255f / 255f, 56f / 255f, 46f/255f, 1f);


    // Start is called before the first frame update
    void Update()
    {
        sp = sprite.GetComponent<SpriteRenderer>();

        if (rarity == "Common")
        {
            itemPrice.text = string.Format("{00}G", commonPrice);
            sp.color = commonColor;
        }
        if(rarity == "Rare")
        {
            itemPrice.text = string.Format("{00}G", rarePrice);
            sp.color = rareColor;
        }
        if(rarity == "Legendary")
        {
            itemPrice.text = string.Format("{00}G", legendaryPrice);
            sp.color = legendaryColor;
        }
        StaticVars = GetComponent<StaticVars>();
    }

    public void BuyItem()
    {
        
        if(rarity == "Common")
        {
            if(StaticVars.TotalGold >= commonPrice)
            {
                StaticVars.TotalGold -= commonPrice;
                if(title.text == "Motor Oil")
                {
                    print("Yay");
                    StaticVars.TurnSpeed += 10;
                }
                else if(title.text == "Energy Drink")
                {
                    print("Drink");
                    StaticVars.TotalAccelerationAmount += 0.01f;
                }
                else if (title.text == "Brake Enhancements")
                {
                    print("Brake");
                    StaticVars.TotalDecelerationAmount += 0.001f;
                }
                else if (title.text == "Upgraded Engine")
                {
                    print("Engine");
                }
            }
            
        }

        if(rarity == "Rare")
        {
            if(StaticVars.TotalGold >= rarePrice)
            {
                StaticVars.TotalGold -= rarePrice;
                if (title.text == "Efficient Blasters")
                {
                    print("blaster");
                }
                else if (title.text == "Augmented Lasers")
                {
                    print("laser");
                }
                else if (title.text == "Side Blasters")
                {
                    print("side");
                }
            } 
        }

        if(rarity == "Legendary")
        {
            if(StaticVars.TotalGold >= legendaryPrice)
            {
                StaticVars.TotalGold -= legendaryPrice;
                if (title.text == "Money Printer")
                {
                    print("money");
                }
            }   
        }
    }
}
