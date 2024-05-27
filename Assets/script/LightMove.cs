using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightMove : MonoBehaviour
{
    Light playerlight;

    float Lightsource = 0.01f;
    bool lightFlag = false;
    bool deathFlag = false;

    void Start()
    {
        playerlight = GetComponent<Light>();
    }

    void Update()
    {
        playerlight.intensity -= 0.0001f;
        if (Input.GetKey(KeyCode.F))
        {
            playerlight.intensity += 0.0002f;
            lightFlag = true;
        }
        else
        {
            lightFlag = false;
        }

        if (playerlight.intensity <= 0) 
        {
            deathFlag = true;
        }
        else
        {
            deathFlag = false;
        }

        if (playerlight.intensity > 1)
        {
            playerlight.intensity = 1;
        }
    }

    void Scene()
    {
        if (deathFlag == true) 
        {
            Debug.Log("ƒ`ƒFƒ“ƒW");
            SceneManager.LoadScene("ClearScene");
        }
    }

    public bool GetLightFlag()
    {
        return lightFlag;
    }
    public bool GetDeathFlag()
    {
        return deathFlag;
    }

}
