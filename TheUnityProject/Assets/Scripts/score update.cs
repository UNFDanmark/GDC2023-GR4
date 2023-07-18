using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FUNNYYYYJOKE : MonoBehaviour
{
    public TMP_Text scoreText;
    private int scoreupdate;

    // Update is called once per frame
    void Update()
    {
       scoreupdate = enemy.score;
       scoreText.text = "Score: " + scoreupdate;
       print("Score: " + scoreupdate);
    }
}
