using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static int TotalGold = 0;

    public static float SaveTimer = 0f;

    public bool isGoing = true;

    // Start is called before the first frame update
    void Start()
    {
        Timer.instance.StartTimer();
        ShopTime.instance.StartTimer();
    }

    void Update()
    {
        AddGold();
        if(!isGoing)
        {
            LoadShop();
        }
    }

    private void AddGold()
    {
        GoldCounter.instance.Gold = TotalGold;
    }

    private void LoadShop()
    {
        Timer.instance.SaveTime();
        
    }






}
