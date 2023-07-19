using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dashcooldowntext : MonoBehaviour
{
    private float dash;

    public TMP_Text dashtext;

    public DiogoGoncalves dashScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dash = dashScript.dashCooldownTimer;
        dashtext.text = "Dash cooldown: " + dash;
    }
}
