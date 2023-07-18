using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public int enemyhp;
    
    public enemyspawner fjendeCamp;
    private NavMeshAgent agent;
    public Transform player;
    [SerializeField] public int score;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.position;
        if (enemyhp <= 0)
        {
            Destroy(gameObject);
            score += 10;
        }
    }
    
}