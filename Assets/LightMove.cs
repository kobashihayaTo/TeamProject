using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    Light playerlight;

    float Lightsource = 0.01f;
    bool lightFlag = false;

    void Start()
    {
        playerlight = GetComponent<Light>();
    }

    void Update()
    {
        playerlight.intensity -= 0.001f;
        if (Input.GetKey(KeyCode.F))
        {
            playerlight.intensity += 0.02f;
            lightFlag = true;
        }
        else
        {
            lightFlag = false;
        }
    }

    public bool GetLightFlag()
    {
        return lightFlag;
    }

}
