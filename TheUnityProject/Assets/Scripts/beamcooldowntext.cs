using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class beamcooldowntext : MonoBehaviour
{

    private float beam;

    public TMP_Text beamtext;

    public Beam beamscript;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beam = beamscript.beamCooldownTimer;
        beamtext.text = "Beam cooldown: " + beam;
    }
}
