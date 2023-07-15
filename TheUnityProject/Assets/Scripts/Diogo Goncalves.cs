using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class DiogoGonclaves : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed = 1;
   
    private Rigidbody krop;

    private float backAnForthInput;
    private float sidewaysInput;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        backAnForthInput = Input.GetAxis("Vertical");
        sidewaysInput = Input.GetAxis("Horizontal");
        
    }


    private void FixedUpdate()
    {
        Vector3 moveVector = transform.forward * (speed * backAnForthInput);
        Vector3 leftrightVector = transform.right * (speed * sidewaysInput);
        moveVector.y = krop.velocity.y;
        krop.velocity = moveVector;
        // if (Input.GetAxis("Vertical") * speed);
        //krop = gameObject.GetComponent<Rigidbody>();
        //krop.velocity = transform.forward * speed;
        
        //transform.(Vector3.up, );
                 //Vector3 moveVector = transform.forward * (speed * moveInput);
                 //moveVector.y = krop.velocity.y;
                 //krop.velocity = moveVector;

    }


    


}
    
