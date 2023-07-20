using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;


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
    [SerializeField]private float damagecooldowntimer;
    [SerializeField] public AudioSource dashlyd;
    [SerializeField]public AudioSource damageTaken;
    [SerializeField] public AudioSource norMusic;
    [SerializeField] public AudioSource lowMusic;
    [SerializeField] public float musicSwitchTime;
    [SerializeField] public float musicSwitchLevel;
    [SerializeField] public float musicVolumeLevel;
    [SerializeField] private float dashcooldown;
    [SerializeField] public float dashCooldownTimer;
     public AudioSource teleport;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        norMusic.volume = musicVolumeLevel;

        lowMusic.volume = 0;

    }

    // Update is called once per frame
    void Update()
    {
        


        if (playerhp <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        backAnForthInput = Input.GetAxis("Vertical");
        sidewaysInput = Input.GetAxis("Horizontal");
        turnInputHorizontal = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up,turnSpeed * turnInputHorizontal * Time.deltaTime);

        if (playerhp <= musicSwitchLevel)
        {

            norMusic.volume = norMusic.volume - musicSwitchTime;

            if (lowMusic.volume < musicVolumeLevel)
            {
                lowMusic.volume = lowMusic.volume + musicSwitchTime;
            }
        }

        if (Input.GetButtonDown("Dash") && dashCooldownTimer <= 0)
        {
            Vector3 moveVectordash = transform.forward * (backAnForthInput);
            Vector3 leftrightVectordash = transform.right * (sidewaysInput);
            Vector3 moveDirectiondash = (moveVectordash + leftrightVectordash).normalized;
            
            krop.AddForce(moveDirectiondash*dashspeed,ForceMode.Impulse);

            dashlyd.Play();

            dashCooldownTimer = dashcooldown;
            


        }

        if (damagecooldowntimer > 0)
        {
            damagecooldowntimer -= Time.deltaTime;
        }

        if (dashCooldownTimer > 0)
        {
            dashCooldownTimer -= Time.deltaTime;
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

        
       
        
        krop.velocity = finalForce;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Fjende" && damagecooldowntimer <= 0)
        {
            playerhp -= 20;
            damageTaken.Play();
            damagecooldowntimer = damagecooldown;

            if(playerhp == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
        
   
    }






}
    
