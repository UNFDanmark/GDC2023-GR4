using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPupdate : MonoBehaviour
{
    private int HP;

    public TMP_Text hpText;

    public DiogoGoncalves GoncalvesScript;
    

    // Update is called once per frame
    void Update()
    {
        HP = GoncalvesScript.playerhp;
        hpText.text = "HP: " + HP;
        //scoreText.text = "Score :" + scoreupdate;
    }
}
