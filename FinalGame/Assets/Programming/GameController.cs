using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static int TotalGold = 0;

    // Start is called before the first frame update
    void Start()
    {
        Timer.instance.StartTimer();
    }

    void Update()
    {
        AddGold();
    }

    private void AddGold()
    {
        GoldCounter.instance.Gold = TotalGold;
    }


}
