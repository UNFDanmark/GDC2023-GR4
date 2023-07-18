using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Higestscore : MonoBehaviour
{

    public scoremanager highscore;

    public TMP_Text highestscore;

    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = highscore.currenthighscore;
        highestscore.text = "Highscore: " + score;
    }
}
