using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addroom : MonoBehaviour
{

    RoomTemplates templates;


    private void Awake()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.Rooms.Add(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
