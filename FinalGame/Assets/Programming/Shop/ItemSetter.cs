using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemSetter : MonoBehaviour
{
    [Tooltip("0 = Common, 1 = Rare, 2 = Legendary")]
    public int rarity = 0;

    public TMP_Text TitleText;
    public TMP_Text DescText;
    int n = 0;

    // Start is called before the first frame update
    void Start()
    {
        //n = Random.Range(0, 2);
        n = 0;
        if (n == 0)
        {
            TitleText.text = string.Format("Motor Oil");
            DescText.text = string.Format("Increases Turn Speed");
        }
    }
}
