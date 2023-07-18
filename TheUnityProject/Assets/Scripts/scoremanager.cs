using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{
    public TMP_Text highscore;
    private int finalscore;
    private int currenthighscore;

    // Update is called once per frame
    void Update()
    {
        //if (diogo.playerhp) <= 0)
        {
            finalscore = enemy.score;
            calculatehighscore(finalscore);
        }
    }

    void calculatehighscore(int finalscore)
    {
        //if (currenthighscore < finalscore)
        {
            currenthighscore = finalscore;
        }
    }

}
