using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPupdate : MonoBehaviour
{
    private int HP;

    public TMP_Text tmpText;

    public DiogoGoncalves GoncalvesScript;

    // Update is called once per frame
    void Update()
    {
        HP = GoncalvesScript.playerhp;
        tmpText.text = "HP: " + HP;
    }
}
