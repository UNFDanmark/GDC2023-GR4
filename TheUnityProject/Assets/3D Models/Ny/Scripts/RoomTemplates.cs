using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class RoomTemplates : MonoBehaviour
{
    public NavMeshSurface surface;

    public GameObject[] d;
    public GameObject[] r;
    public GameObject[] u;
    public GameObject[] l;

    public GameObject blockRoom;

    public List<GameObject> Rooms;
    int preCount;

    public float waitTime;
    public bool endSpawned;
    public GameObject portal;

    public bool isbaked;

    private void Start()
    {

        InvokeRepeating("bakeNavMesh", 0, 1);
    }

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

    void bakeNavMesh()
    {
      if(preCount != Rooms.Count)
        {
            preCount = Rooms.Count;
        }
        else if(isbaked == false) 
        {
            isbaked = true;
            surface.BuildNavMesh();
        }
    }
}
