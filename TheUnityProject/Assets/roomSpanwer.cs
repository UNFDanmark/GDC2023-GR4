using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpanwer : MonoBehaviour
{

    public int openingDirection;
    RoomTemplates tamplates;
    int rand;

    public bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        tamplates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("spawn", 1);
    }

    // Update is called once per frame
    void spawn()
    {
        if(!spawned) {

            if (openingDirection == 1)
            {
                rand = Random.Range(0, tamplates.d.Length);
                Instantiate(tamplates.d[rand], transform.position, tamplates.d[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                rand = Random.Range(0, tamplates.u.Length);
                Instantiate(tamplates.u[rand], transform.position, tamplates.u[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                rand = Random.Range(0, tamplates.l.Length);
                Instantiate(tamplates.l[rand], transform.position, tamplates.l[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                rand = Random.Range(0, tamplates.r.Length);
                Instantiate(tamplates.r[rand], transform.position, tamplates.r[rand].transform.rotation);
            }
            spawned = true;
        }
     


        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Spawnpoint"))
        {
            print("Destroy");
            Destroy(gameObject);
        }

    }

 
}
