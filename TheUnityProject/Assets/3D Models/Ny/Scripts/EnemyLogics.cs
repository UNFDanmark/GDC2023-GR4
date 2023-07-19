using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogics : MonoBehaviour
{
    bool isTrapped;
     Animator animator;


    private void Awake()
    {
        animator = GetComponentInParent<Animator>();
        int rand = Random.Range(0, 100);

        if(rand < 20)
        {
            isTrapped = true;
        }

        animator.SetBool("isTrapped", false);
    }

    private void Update()
    {

        if (isTrapped)
        {



        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isTrapped)
            {
                animator.SetBool("isTrapped", isTrapped);
            }
            else
            {
                Destroy(this);
            }
        }
       
    }
}
