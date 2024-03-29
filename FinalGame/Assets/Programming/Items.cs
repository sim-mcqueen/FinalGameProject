﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Items : MonoBehaviour
{
    
    public TMP_Text TitleText;
    public TMP_Text DescText;
    public GameObject rerollButton;
    public float legendaryWeight = 95f;
    public float rareWeight = 75f;

    private ItemList item;

    private enum ItemList
    {
        MotorOil,
        EnergyDrink,
        BrakeEnhancements,
        UpgradedEngine,
        EfficientBlasters,
        AugmentedLasers,
        MoneyPrinter
    }
    
    void Start()
    {
        ReRoll();
    }

    public void RerollPurchase()
    {
        if(StaticVars.TotalGold >= 20)
        {
            StaticVars.TotalGold -= 20;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    public void ReRoll()
    {
            var commonItems = (ItemList)Random.Range((int)ItemList.MotorOil, (int)ItemList.UpgradedEngine + 1);
            var rareItems = (ItemList)Random.Range((int)ItemList.EfficientBlasters, (int)ItemList.AugmentedLasers + 1);
            var LegendaryItems = (ItemList)(int)ItemList.MoneyPrinter;
        
            int weightedChance = Random.Range(0, 100);

            if (!(weightedChance < legendaryWeight))
            {
                item = LegendaryItems;
            }
            else if (!(weightedChance < rareWeight))
            {
                item = rareItems;
            }
            else
            {
                item = commonItems;
            }

            switch (item)
            {
                case ItemList.MotorOil:
                    ChangeValues("Motor Oil", "Increase your turn speed", "Common");
                    break;

                case ItemList.EnergyDrink:
                    ChangeValues("Energy Drink", "Decreases the time it takes for you to hit max speed", "Common");
                    break;

                case ItemList.BrakeEnhancements:
                    ChangeValues("Brake Enhancements", "Decrease the time it takes for you to stop", "Common");
                    break;

                case ItemList.UpgradedEngine:
                    ChangeValues("Upgraded Engine", "Increase max move speed", "Common");
                    break;

                case ItemList.EfficientBlasters:
                    ChangeValues("Efficient Blasters", "Increase attack speed", "Rare");
                    break;

                case ItemList.AugmentedLasers:
                    ChangeValues("Augmented Lasers", "Increase laser speed", "Rare");
                    break;

                case ItemList.MoneyPrinter:
                    ChangeValues("Money Printer", "Doubles amount of gold gained", "Legendary");
                    break;
            }
    }
        
    

    private void ChangeValues(string title, string description, string rarity)
    {
        gameObject.GetComponent<PurchaseItem>().rarity = rarity;
        TitleText.text = title;
        DescText.text = description;
    }
}
