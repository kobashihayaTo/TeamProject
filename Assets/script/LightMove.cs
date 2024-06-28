using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
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
    [SerializeField]
    PlayerMove playermove;

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
            playerlight.intensity += 0.0002f;
            playerSlider.value += 0.0002f;
            lightFlag = true;
        }
        else
        {
            lightFlag = false;
            playerSlider.value -= 0.0001f;
            playerlight.intensity -= 0.0001f;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(playermove.PlayerTransform().x, 19.5f, playermove.PlayerTransform().z + 1);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(playermove.PlayerTransform().x,19.5f, playermove.PlayerTransform().z - 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(playermove.PlayerTransform().x - 1, 19.5f, playermove.PlayerTransform().z);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(playermove.PlayerTransform().x + 1, 19.5f, playermove.PlayerTransform().z);

        }

        if (playerlight.intensity==1)
        {
            Debug.Log("1になった");
        }
        if (playerSlider.value==1) 
        {
            Debug.Log("2になった");
        }

        if (playerlight.intensity == 0) 
        {
            deathFlag = true;

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
