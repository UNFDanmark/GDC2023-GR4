using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{


    public GameObject[] d;
    public GameObject[] r;
    public GameObject[] u;
    public GameObject[] l;

    public GameObject blockRoom;

    public List<GameObject> Rooms;

    public float waitTime;
    public bool endSpawned;
    public GameObject portal;

    private void Update()
    {
       if(waitTime <= 0 && endSpawned == false)
        {
            for(int i = 0; i < Rooms.Count; i++) {
            if(i == Rooms.Count - 1 )
                {
                    Instantiate(portal, Rooms[i].transform.position,Quaternion.identity);
                    endSpawned = true;
                }
            
            
            }   

        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
