using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 10;
  
    
    private float turnInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Mouse X");
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up,turnSpeed * turnInput);
    }
}
