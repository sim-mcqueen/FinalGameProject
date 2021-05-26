using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    

    private enum ItemList
    {
        MotorOil,
        DoubleCoins,
        Etc
    }
    
    

    private void ChooseItem()
    {
        var item = (ItemList)Random.Range((int)ItemList.MotorOil, (int)ItemList.MotorOil);
        switch (item)
        {
            case ItemList.MotorOil:
                StaticVars.TurnSpeed += 5f;
                break;
        }
    }
}
