using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

     EnemyLogics logic;

    [SerializeField] private Transform spawnArea;
    [SerializeField] private GameObject Enemy;
    private List<enemy> enemyAmount = new List<enemy>();
    [SerializeField] private int maxAmountOfEnemies;

    Vector3 offset; 

     private Transform player;

    float wait = 4f;

    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        logic = GetComponent<EnemyLogics>();

        maxAmountOfEnemies = Random.Range(1, 5);

        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyAmount.Count >= maxAmountOfEnemies)
        {
            for (int i = 0; i < enemyAmount.Count; i++)
            {
                if (enemyAmount[i] != null)
                {
                    return;
                }
                else
                {
                    enemyAmount.Clear();
                    logic.animator.SetBool("isTrapped", false);

                }
            }

        }

    }

    public IEnumerator CallSpawner()
    {
        while (maxAmountOfEnemies > enemyAmount.Count)
        {
            spawn();

            yield return new WaitForSeconds(wait);



        }
        
    }
    
    Vector3 PositionRandomizer()
    {
      Vector3 spwanpoint =  spawnArea.transform.position;
        int randomNum = Random.Range(1, 5);

        switch (randomNum)
        {
            case 1:
                spwanpoint.x += 20;
                break;

            case 2:
                spwanpoint.x -= 20;

                break;
            case 3:
                spwanpoint.z -= 20;

                break;
            case 4:
                spwanpoint.z += 20;

                break;

            default:
                break;

        }
        return spwanpoint;


    }

    private void spawn()
    {
        GameObject newEnemy = Instantiate(Enemy,PositionRandomizer(),Enemy.transform.rotation);
        enemy Enemyscript = newEnemy.GetComponent<enemy>();
        Enemyscript.player = player;
        Enemyscript.mom = this;
        enemyAmount.Add(Enemyscript);
    }
}
    


