using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPupdate : MonoBehaviour
{
    private int HP;

    //private int scoreupdate;

    public TMP_Text hpText;

    //public TMP_Text scoreText;

    public DiogoGoncalves GoncalvesScript;

    //public enemy enemyscript;

    // Update is called once per frame
    void Update()
    {
        //scoreupdate = enemyscript.score;
        HP = GoncalvesScript.playerhp;
        //scoreupdate = ememyscript.score;
        hpText.text = "HP: " + HP;
        //scoreText.text = "Score :" + scoreupdate;
    }
}
