using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Beam : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 direction;
    private float maxDistance = 100;

    public LayerMask fjender;

    public LayerMask wall;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            beamcheck();
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
            print(fjendekode.enemyhp);
            Debug.DrawRay(origin, direction * 1000, Color.red);
            print("fjender");
            return true;
        }
        else if (Physics.Raycast(origin, direction, maxDistance, wall))
        {
            Debug.DrawRay(origin, direction * 1000, Color.yellow);
            print("væg");
            return true;
        }
        else
        {
            Debug.DrawRay(origin, direction * 1000, Color.black);
            return false;
        }

     
    }

    void DealDamage()
    {
        
    }

}
       
        
        

           
            
    
    

