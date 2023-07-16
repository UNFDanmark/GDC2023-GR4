using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float cooldown;
    [SerializeField] private int maxamount;
    [SerializeField] private Transform area;

    private float timeLeft;
    public int currentAmounts;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    int bestemposition()
    {
        return 0;
    }
}
