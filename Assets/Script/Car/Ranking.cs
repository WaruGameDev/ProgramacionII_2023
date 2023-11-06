using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class RankingPos
{
    public string namePlayer;
    public int scorePlayer;
}
public class Ranking : MonoBehaviour
{
    public static Ranking instance;
    public List<RankingPos> rankingPosList;
    public GameObject rankingPosPanel;
    public Transform scroll;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
       rankingPosList = rankingPosList.OrderByDescending(a => a.scorePlayer).ToList();
       CreateVisualRanking();
        
    }

    public void CreateVisualRanking()
    {
        foreach (var r in rankingPosList)
        {
            GameObject rK = Instantiate(rankingPosPanel, scroll);
            rK.GetComponent<FillInfoRanking>().FillInfo(r.namePlayer,r.scorePlayer.ToString());
        }
    }
}
