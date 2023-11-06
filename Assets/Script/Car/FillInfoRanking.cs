using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FillInfoRanking : MonoBehaviour
{
    public TextMeshProUGUI nameRanking, scoreRanking;

    public void FillInfo(string n, string s)
    {
        nameRanking.text = n;
        scoreRanking.text = s;
    }
}
