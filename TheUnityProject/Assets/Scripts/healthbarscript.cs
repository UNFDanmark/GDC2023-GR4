using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    [SerializeField] private DiogoGoncalves Goncalves;
    [SerializeField] private Image healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)Goncalves.playerhp / 100f;
    }
}
