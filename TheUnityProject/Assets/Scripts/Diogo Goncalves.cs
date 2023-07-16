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
    [SerializeField] private float dashspeed;

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
        //get walkForce
        Vector3 moveVector = transform.forward * (backAnForthInput);
        Vector3 leftrightVector = transform.right * (sidewaysInput);
        Vector3 moveDirection = (moveVector + leftrightVector).normalized;
        Vector3 walkForce = moveDirection * speed;
        
        //apply gravity
        Vector3 finalForce = walkForce;
        finalForce.y = krop.velocity.y;

        //apply dash
        if (Input.GetButtonDown("Dash"))
        {
            Vector3 dashForce = dashspeed * moveDirection;
            finalForce = finalForce + dashForce;
        }
        
        krop.velocity = finalForce;

    }


    


}
    
