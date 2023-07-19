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
    public static int score;
    public enemyspawner mom;
    [SerializeField] public AudioSource enemyDeathSound;

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
            mom.killCount++;
            Destroy(gameObject);
            score += 100;
            enemyDeathSound.Play();

        }
    }
    
}
