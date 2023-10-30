using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadNeki : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    private void Start()
    {
        DataManager.Load();
        tmp.text = "Level: " + DataManager.level + "\n" + "Coins: " + DataManager.coins;
    }
}
