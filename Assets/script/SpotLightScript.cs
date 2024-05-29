using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript : MonoBehaviour
{
    Light spotlight;

    float Lightsource = 0.01f;

    void Start()
    {
        spotlight = GetComponent<Light>();
        //spotlight.intensity = 0;
    }

    void Update()
    {
        if (spotlight.intensity >= 1) 
        {
            spotlight.intensity = 1;
        }
        
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Debug.Log("‚ ‚½‚Á‚½");
            spotlight.intensity += 0.1f;
        }
    }
}
