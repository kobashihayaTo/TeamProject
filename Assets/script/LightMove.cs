using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightMove : MonoBehaviour
{
    [SerializeField]
    Light playerlight;
    [SerializeField]
    SpotLightManeger spotLightManeger;

    float Lightsource = 0.01f;
    bool lightFlag = false;
    bool deathFlag = false;

    void Scene()
    {
        if (deathFlag == true)
        {
            Debug.Log("チェンジ");
            SceneManager.LoadScene("OverScene");
        }
    }

    void Update()
    {

        playerlight.intensity -= 0.001f;
        spotLightManeger.SpotTimer = playerlight.intensity;
        if (Input.GetKey(KeyCode.F))
        {
            playerlight.intensity += 0.2f;
            
            lightFlag = true;
        }
        else
        {
            lightFlag = false;
        }

        if (playerlight.intensity == 0) 
        {
            //deathFlag = true;

        }
        else
        {
            deathFlag = false;
        }
        //強度変えたいときはここの数字をいじって
        if (playerlight.intensity > 1)
        {
            playerlight.intensity = 1;
        }
        Scene();
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
