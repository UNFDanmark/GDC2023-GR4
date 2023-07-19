using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Beam : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 direction;
    private int maxDistance = 100000000;

    public AudioSource beamlyd;
    public LayerMask fjender;

    public LayerMask wall;

    public AudioSource hitMark;

    public float beamCooldown;
    public float beamCooldownTimer;
    public float beamLydPitchVariation;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&& beamCooldownTimer <= 0)
        {
            beamcheck();

            beamlyd.pitch = Random.Range(1-beamLydPitchVariation,1+ beamLydPitchVariation);

            beamlyd.Play();
        }

        if (beamCooldownTimer > 0);
        {
            beamCooldownTimer -= Time.deltaTime;
        }
    }

    bool beamcheck()
    {
        
        origin = transform.position;
        direction = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray beamRay = new Ray(origin, direction);
        if (Physics.Raycast(beamRay, out hit, maxDistance, fjender))
        {
            enemy fjendekode = hit.transform.gameObject.GetComponent<enemy>();
            fjendekode.enemyhp -= 10;

            hitMark.pitch = beamlyd.pitch;

            hitMark.Play();
            beamCooldownTimer = beamCooldown;
            print(hit.transform.gameObject.name);
            
            return true;
        }
        else
        {
            beamCooldownTimer = beamCooldown;
            return false;
        }

     
    }

}
       
        
        

           
            
    
    

