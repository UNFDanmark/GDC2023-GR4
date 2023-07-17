using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class DiogoGoncalves : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed = 10000;
   [SerializeField]
    private Rigidbody krop;
    [SerializeField] public float turnInputHorizontal;
    [SerializeField] private float dashspeed;

    private float backAnForthInput;
    private float sidewaysInput;
    [SerializeField] public int playerhp;
    [SerializeField]private float damagecooldown;
    private float damagecooldowntimer;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhp <= 0)
        {
            Destroy(gameObject);
        }

        backAnForthInput = Input.GetAxis("Vertical");
        sidewaysInput = Input.GetAxis("Horizontal");
        turnInputHorizontal = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up,turnSpeed * turnInputHorizontal * Time.deltaTime);  
        
        
        if (Input.GetButtonDown("Dash"))
        {
            Vector3 moveVector = transform.forward * (backAnForthInput);
            Vector3 leftrightVector = transform.right * (sidewaysInput);
            Vector3 moveDirection = (moveVector + leftrightVector).normalized;
            
            krop.AddForce(moveDirection*dashspeed,ForceMode.Impulse);
            
            
            
        }

        if (damagecooldowntimer > 0)
        {
            damagecooldowntimer -= Time.deltaTime;
        }
    }


    void FixedUpdate()
    {
        //get walkForce
        Vector3 moveVector = transform.forward * (backAnForthInput);
        Vector3 leftrightVector = transform.right * (sidewaysInput);
        Vector3 moveDirection = (moveVector + leftrightVector).normalized;
        Vector3 walkForce = moveDirection * speed;
        
        //apply gravity
        Vector3 finalForce = walkForce;
        finalForce.y = krop.velocity.y;

        //apply dash
       
        
        krop.velocity = finalForce;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (damagecooldowntimer <= 0)
        {
            if (collision.collider.tag == "Fjende")
            {
                playerhp -= 5;
                damagecooldowntimer = damagecooldown;
            }
        }
        
   
    }


    


}
    
