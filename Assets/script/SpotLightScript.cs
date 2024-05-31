using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript : MonoBehaviour
{
    Light spotlight;
    bool spotlightFlag;

    float Lightsource = 0.01f;

    void Start()
    {
        spotlight = GetComponent<Light>();
        spotlightFlag = false;
        //spotlight.intensity = 0;
    }

    void Update()
    {
        if (spotlightFlag == true) 
        {
            Debug.Log("‚ ‚½‚Á‚½");
            spotlight.intensity += 0.1f;
        }

        if (spotlight.intensity >= 1) 
        {
            spotlight.intensity = 1;
        }
        
    }

    public void SetspotlightFlag(bool spotlightFlag)
    {
        this.spotlightFlag = spotlightFlag;
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            

        }
    }
}
