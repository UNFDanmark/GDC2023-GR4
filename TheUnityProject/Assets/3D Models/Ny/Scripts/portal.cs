using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    RoomTemplates roomTemplates;
    public GameObject starterRoom;

    public Animator animator;

    Transform player;
    private void Awake()
    {
        roomTemplates = FindObjectOfType<RoomTemplates>();
        animator = GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.transform;
            Invoke("teleport", 1);
            animator.SetTrigger("Fade");
        }
    }

    public void teleport()
    {
        player.transform.position = new Vector3(0, .2f, 0);

        for (int i = 0; i < roomTemplates.Rooms.Count; i++)
        {
            Destroy(roomTemplates.Rooms[i]);
        }
        roomTemplates.Rooms.Clear();

        Instantiate(starterRoom, Vector3.zero, Quaternion.identity);
        Destroy(gameObject.transform.parent.gameObject);
        roomTemplates.waitTime = 6;
        roomTemplates.endSpawned = false;
    }
}
