using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int SaveGold = 0;

    public float SaveTimer = 0f;

    public string ShopScene = "AndrewShopTest";

    public bool isGoing = true;


    private StaticVars StaticVars;


    private void Awake()
    {
        StaticVars = GetComponent<StaticVars>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SaveGold = StaticVars.TotalGold;
        SaveTimer = StaticVars.TimePassed;
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
        GoldCounter.instance.Gold = SaveGold;
    }

    private void LoadShop()
    {
        Timer.instance.SaveTime();
        StaticVars.TotalGold = SaveGold;
        StaticVars.TimePassed = SaveTimer;
        StartCoroutine(WaitForTwoSeconds());
    }

    IEnumerator WaitForTwoSeconds()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(ShopScene);
    }




}
