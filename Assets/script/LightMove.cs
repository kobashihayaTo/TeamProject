using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LightMove : MonoBehaviour
{
    [SerializeField]
    Light playerlight;
    [SerializeField]
    SpotLightManeger spotLightManeger;
    [SerializeField]
    public Slider playerSlider;

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

    void Start()
    {
        playerlight.intensity = 1.0f;
        playerSlider.value = 1.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F)|| Input.GetKey(KeyCode.Return))
        {
            playerlight.intensity += 0.002f;
            playerSlider.value += 0.002f;
            lightFlag = true;
        }
        else
        {
            lightFlag = false;
            playerSlider.value -= 0.001f;
            playerlight.intensity -= 0.001f;
        }

        if(playerlight.intensity==1)
        {
            Debug.Log("1になった");
        }
        if (playerSlider.value==1) 
        {
            Debug.Log("2になった");
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
        if (playerlight.intensity >= 1)
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
