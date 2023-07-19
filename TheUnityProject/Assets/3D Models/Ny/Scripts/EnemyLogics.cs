using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogics : MonoBehaviour
{
    public bool isTrapped;
    public Animator animator;
    enemyspawner Enemyspawner;

    private void Awake()
    {
        animator = GetComponentInParent<Animator>();
        Enemyspawner = GetComponent<enemyspawner>();
        int rand = Random.Range(0, 100);

        if(rand < 20)
        {
            isTrapped = true;
        }

        animator.SetBool("isTrapped", false);
    }

    private void Update()
    {

      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isTrapped)
            {
                StartCoroutine(Enemyspawner.CallSpawner()); 
                animator.SetBool("isTrapped", isTrapped);
            }
            else
            {
                Destroy(this);
            }
        }
       
    }
}
