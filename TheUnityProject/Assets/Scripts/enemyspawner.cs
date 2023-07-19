using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    

    
    [SerializeField] private Transform spawnArea;
    [SerializeField] private GameObject Enemy;
    private List<enemy> enemyAmount = new List<enemy>();
    [SerializeField] private int maxAmountOfEnemies;
    public int killCount = 0;
    

    [SerializeField] private Transform player;

    float wait = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CallSpawner());

        maxAmountOfEnemies = Random.Range(1, 5);

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public IEnumerator CallSpawner()
    {
        while (maxAmountOfEnemies > enemyAmount.Count)
        {
            yield return new WaitForSeconds(wait);
            spawn();
        }
        
    }
    
    Vector3 PositionRandomizer()
    {
        float x = Random.Range(-spawnArea.localScale.x / 2, spawnArea.localScale.x / 2);
        float y = Random.Range(-spawnArea.localScale.y / 2, spawnArea.localScale.y / 2);
        return new Vector3(x, 0.75f, y);
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
    


