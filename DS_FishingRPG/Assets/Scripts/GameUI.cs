using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI treasureText;

    // instance
    public static GameUI instance;

    void Awake()
    {
        instance = this;
    }

    public void UpdateGoldText(int gold)
    {
        goldText.text = "<b>Fish:</b> " + gold;
    }

    public void UpdateTreasureText(int treasure)
    {
        goldText.text = "<b>Coins:</b> " + treasure;
    }

}
