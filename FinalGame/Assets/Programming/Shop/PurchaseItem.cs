/****************
* Name: Andrew Dahlman-Oeth
* Date:
* Desc:
****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PurchaseItem : MonoBehaviour
{
    public string rarity;
    public TMP_Text itemPrice;
    public TMP_Text title;
    public GameObject description;
    public GameObject sprite;
    public GameObject buyButton;
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
                OnBuy();

                if (title.text == "Motor Oil")
                {
                    print("Yay");
                    StaticVars.TurnSpeed += 10;
                }
                else if(title.text == "Energy Drink")
                {
                    print("Drink");
                    StaticVars.TotalAccelerationAmount += 0.5f;
                }
                else if (title.text == "Brake Enhancements")
                {
                    print("Brake");
                    StaticVars.TotalDecelerationAmount += 1f;
                }
                else if (title.text == "Upgraded Engine")
                {
                    print("Engine");
                    StaticVars.TotalMoveSpeed += 0.5f;
                }
            }
            
        }

        if(rarity == "Rare")
        {
            if(StaticVars.TotalGold >= rarePrice)
            {
                StaticVars.TotalGold -= rarePrice;
                OnBuy();

                if (title.text == "Efficient Blasters")
                {
                    print("blaster");
                    StaticVars.TotalAttackSpeed -= 0.02f;
                }
                else if (title.text == "Augmented Lasers")
                {
                    print("laser");
                    StaticVars.TotalProjectileSpeed += 0.1f;
                }
                else if (title.text == "Side Blasters")
                {
                    print("side");
                    //StaticVars.TotalProjectiles += 1;
                }
            } 
        }

        if(rarity == "Legendary")
        {
            if(StaticVars.TotalGold >= legendaryPrice)
            {
                StaticVars.TotalGold -= legendaryPrice;
                OnBuy();

                if (title.text == "Money Printer")
                {
                    print("money");
                    StaticVars.MoneyMultiplier += 1;
                }
            }   
        }
    }
    private void OnBuy()
    {
        Button buy = buyButton.GetComponent<Button>();
        buy.interactable = false;
        var audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
