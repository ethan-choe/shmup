using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text Score;
    public Text Lives;
    private int scoreCnt, livesCnt;
    public static UIScript S;
    void Awake()
    {
        scoreCnt = 0;
        livesCnt = 1;
        S = this;
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        Score.text = scoreCnt.ToString();

        Lives.text = livesCnt.ToString();
    }
}
