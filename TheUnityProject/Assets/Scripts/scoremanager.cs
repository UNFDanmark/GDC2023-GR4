using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{
    public TMP_Text highscore;
    private int finalscore;
    public int currenthighscore;
    public DiogoGoncalves Goncalves;

    // Update is called once per frame
    void Update()
    {
        if (Goncalves.playerhp <= 0)
        {
            finalscore = enemy.score;
            calculatehighscore(finalscore);
            print(finalscore);
        }
    }

    void calculatehighscore(int finalscore)
    {
        if (currenthighscore < finalscore)
        {
            currenthighscore = finalscore;
            
        }
    }

}
