using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public int enemyhp;
    
    public enemyspawner fjendeCamp;
    private NavMeshAgent agent;
    public Transform player;
    DiogoGoncalves script;

    public static int score;
    public enemyspawner mom;
    [SerializeField] public AudioSource enemyDeathSound;

    public int damageRange;

    // Start is called before the first frame update
    void Start()
    {
        script = player.GetComponent<DiogoGoncalves>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.position;
        if (enemyhp <= 0)
        {
            enemyDeathSound.Play();
            Destroy(gameObject);
            score += 15;
            print(Vector3.Distance(transform.position, player.transform.position));

        }


        if (Vector3.Distance(transform.position, player.transform.position) <= damageRange && script.damagecooldowntimer <= 0)
        {
            print("CD");
            script.playerhp -= 10;
            script.damagecooldowntimer = script.damagecooldown;
            script.damageTaken.Play();

            if (script.playerhp <= 0)
           {
                enemy.score = 0;
                SceneManager.LoadScene(2);
            }

        }


    }
    
}
