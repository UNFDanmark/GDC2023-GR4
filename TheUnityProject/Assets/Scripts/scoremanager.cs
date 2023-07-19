using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{
    private int finalscore;
    public int currenthighscore;
    public DiogoGoncalves Goncalves;

    // Update is called once per frame
    void Update()
    {
        if (Goncalves.playerhp <= 0)
        {
            print(finalscore);
            finalscore = enemy.score;
            calculatehighscore(finalscore);
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
