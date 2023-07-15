using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 10;
  
    
    [SerializeField] public float turnInputHorizontal;
    //private float turnInputVertical;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInputHorizontal = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up,turnSpeed * turnInputHorizontal * Time.deltaTime);
        //turnInputVertical = Input.GetAxis("Mouse Y");
    }

    private void FixedUpdate()
    {
        
        //transform.Rotate(Vector3.up, turnSpeed * turnInputVertical);
    }
}
