using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class DiogoGonclaves : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed = 10000;
   [SerializeField]
    private Rigidbody krop;
    [SerializeField] public float turnInputHorizontal;

    private float backAnForthInput;
    private float sidewaysInput;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        backAnForthInput = Input.GetAxis("Vertical");
        sidewaysInput = Input.GetAxis("Horizontal");
        turnInputHorizontal = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up,turnSpeed * turnInputHorizontal * Time.deltaTime);
        
    }


    private void FixedUpdate()
    {
        
        Vector3 moveVector = transform.forward * (speed * backAnForthInput);
        Vector3 leftrightVector = transform.right * (speed * sidewaysInput);
        Vector3 final = moveVector + leftrightVector;
        final.y = krop.velocity.y;
        //krop.velocity = moveVector;
        //leftrightVector.x = krop.velocity.x;
        krop.velocity = final;
        
        // if (Input.GetAxis("Vertical") * speed);
        //krop = gameObject.GetComponent<Rigidbody>();
        //krop.velocity = transform.forward * speed;
        
        //transform.(Vector3.up, );
                 //Vector3 moveVector = transform.forward * (speed * moveInput);
                 //moveVector.y = krop.velocity.y;
                 //krop.velocity = moveVector;

    }


    


}
    
