using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    //guarde el nivel del personaje
    public static int level;
    // dinero que tiene el personaje
    public static int coins;

    public static void Save(int _coins, int _level)
    {
        level = _level;
        coins = _coins;
        
        PlayerPrefs.SetInt("l", level);
        PlayerPrefs.SetInt("c", coins);
    }

    public static void Load()
    {
        level = PlayerPrefs.GetInt("l");
        coins = PlayerPrefs.GetInt("c");
    }
    
}
