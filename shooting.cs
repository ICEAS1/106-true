using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public ParticleSystem partic;

    void Start()
    {
        
    }

    void Update()
    {
        // Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        // RaycastHit hit;
        
        // if(Input.GetButtonDown("Fire1")){

        //     partic.Play();
        //     if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
        //         if(hit.transform.gameObject.tag=="target"){
        //             Destroy(hit.transform.gameObject);
        //         }
               
        //     }     

        // }
    }


}
