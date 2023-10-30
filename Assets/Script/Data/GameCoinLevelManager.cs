using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameCoinLevelManager : MonoBehaviour
{
    public static GameCoinLevelManager instance;
    public int coin;
    public int level;
    public TextMeshProUGUI tmp;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        tmp.text = "level: " + level + "\n" + "coin: " + coin;
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    public void AddCoin(int amount)
    {
        coin += amount;
    }

    public void AddLevel()
    {
        level++;
    }

    public void Save()
    {
        DataManager.Save(coin,level);
    }

    public void Load()
    {
        DataManager.Load();
        level = DataManager.level;
        coin = DataManager.coins;
    }
}
    
    

