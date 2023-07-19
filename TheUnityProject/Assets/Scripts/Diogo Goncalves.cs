using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
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
    [SerializeField] public float musicSwitchTime = 0.0025f;
    [SerializeField] public float musicSwitchLevel = 40f;
    [SerializeField] public float musicVolumeLevel = 0.7f;
    [SerializeField] private float dashcooldown;
    [SerializeField] private float dashCooldownTimer;
   
    

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
            SceneManager.LoadScene("game over");
            
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
            Vector3 moveVector = transform.forward * (backAnForthInput);
            Vector3 leftrightVector = transform.right * (sidewaysInput);
            Vector3 moveDirection = (moveVector + leftrightVector).normalized;
            
            krop.AddForce(moveDirection*dashspeed,ForceMode.Impulse);

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

        //apply dash
       
        
        krop.velocity = finalForce;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Fjende" && damagecooldowntimer <= 0)
        {
            playerhp -= 10;
            damageTaken.Play();
            damagecooldowntimer = damagecooldown;


        }
        
   
    }


    


}
    
