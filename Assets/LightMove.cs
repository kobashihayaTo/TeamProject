using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    Light playerlight;

    int Timer = 500;
    float Lightsource = 0.01f;

    void Start()
    {
        playerlight = GetComponent<Light>();
    }

    void Update()
    {
        Timer--;

        //if(Timer <= 500)
        //{
        //    playerlight.intensity -= Lightsource;
        //}
        //else if(Timer < 0)
        //{
        //    playerlight.intensity = 0.0f;
        //}
    }
}
