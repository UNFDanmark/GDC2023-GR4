using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    [SerializeField] private float cooldown;
    [SerializeField] private int maxamount;
    [SerializeField] private Transform spawnArea;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float spawnCooldown;
    [SerializeField] private int maxAmountOfEnemies;
  
    
    public enemy Enemyscript;
        
 
    private float timeLeftBetweenSpawns;
    [SerializeField] public int currentAmountOfEnemies;
    [SerializeField] private Transform player;

    private int timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 PositionRandomizer()
    {
        float x = Random.Range(-spawnArea.localScale.x / 2, spawnArea.localScale.x / 2);

        float y = Random.Range(-spawnArea.localScale.y / 2, spawnArea.localScale.y / 2);
        
        return new Vector3(x, 0.75f, y);
    }

    private void spawner()
    {
        timeLeftBetweenSpawns -= Time.deltaTime;
        if (timeLeftBetweenSpawns <= 0 && currentAmountOfEnemies < maxAmountOfEnemies)
        {
            
            GameObject newEnemy = Instantiate(Enemy,PositionRandomizer(),Enemy.transform.rotation);
            enemy enemyscript = newEnemy.GetComponent<enemy>();
            enemyscript.player = player;
            
  
            
            timeLeftBetweenSpawns = spawnCooldown;
            currentAmountOfEnemies ++;
        }
    }
}
