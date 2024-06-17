using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
//UIg‚¤‚Æ‚«‚Í–Y‚ê‚¸‚ÉB
using UnityEngine.UI;

public class OnCollisionEnter_Player : MonoBehaviour
{
    [SerializeField]
    public SpotLightScript spotLightScript;
    [SerializeField]
    public SpotLightScript_2 spotLightScript_2;
    [SerializeField] 
    public SpotLightScript_3 spotLightScript_3;
    [SerializeField]
    public SpotLightScript_4 spotLightScript_4;
    [SerializeField]
    public SpotLightScript_5 spotLightScript_5;
    //HP‚ÌUI
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Canvas canvas1;



    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;


    private int Status;  //€”õ‚ª‚Å‚«‚½‚©‚Ç‚¤‚©‚ğ”»’f‚·‚é•Ï”

    int battery1Flag = 0;
    int battery2Flag = 0;
    int battery3Flag = 0;
    int battery4Flag = 0;
    int battery5Flag = 0;

    void ClearScene()
    {
        if (battery1Flag == 1 && battery2Flag == 1 && battery3Flag == 1 && battery4Flag == 1 && battery5Flag == 1)  
        {
            SceneManager.LoadScene("ClearScene");
        }
    }

    void OverScene()
    {
        SceneManager.LoadScene("OverScene");
    }

    //ƒoƒbƒeƒŠ[‚Ì“–‚½‚è”»’è
    void OnCollisionStay(Collision collision)
    {
        #region battery

        spotLightScript.SetspotlightFlag(false);
        spotLightScript_2.SetspotlightFlag_2(false);
        spotLightScript_3.SetspotlightFlag_3(false);
        spotLightScript_4.SetspotlightFlag_4(false);
        spotLightScript_5.SetspotlightFlag_5(false);

        
        if (collision.gameObject.name == "battery-1")
        {
            spotLightScript.SetspotlightFlag(true);

            slider.value += 0.01f;

            if (slider.value >= 1)
            {
                battery1Flag = 1;
                slider.value = 1;
            }
        }
        if (collision.gameObject.name == "battery-2")
        {
            spotLightScript_2.SetspotlightFlag_2(true);

            slider2.value += 0.01f;

            if (slider2.value >= 1)
            {
                
                battery2Flag = 1;
                slider2.value = 1;
            }
        }
        if (collision.gameObject.name == "battery-3")
        {
            spotLightScript_3.SetspotlightFlag_3(true);
            slider3.value += 0.01f;

            if (slider3.value >= 1)
            {
                battery3Flag = 1;
                slider3.value = 1;
            }
        }
        if (collision.gameObject.name == "battery-4")
        {
            spotLightScript_4.SetspotlightFlag_4(true);
            slider4.value += 0.01f;

            if (slider4.value >= 1)
            {
                battery4Flag = 1;
                slider4.value = 1;
            }
        }

        if (collision.gameObject.name == "battery-5")
        {
            spotLightScript_5.SetspotlightFlag_5(true);
            slider5.value += 0.01f;
            if (slider5.value >= 1)
            {
                battery5Flag = 1;
                slider5.value = 1;
            }
        }
        if (collision.gameObject.name == "battery-6")
        {
            //Debug.Log("“–‚½‚Á‚½!");
            
        }
        #endregion
        ClearScene();
    }
    //“G‚Æ‚Ì“–‚½‚è”»’è
    private void OnTriggerStay(Collider other)
    {
        #region enemy

        if (other.gameObject.tag == "enemy")
        {
            OverScene();
        }

        #endregion
    }
    //Ÿ‚ÌŠK‘ws‚­‚Æ‚«‚ÌƒQ[ƒW
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "MoveFirstFloor")
        {
            canvas.enabled = false;
            canvas1.enabled = true;
        }
        if (collider.gameObject.name == "MoveSecondFloor")
        {
            canvas.enabled = true;
            canvas1.enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        slider2.value = 0;
        slider3.value = 0;
        slider4.value = 0;
        slider5.value = 0;
        canvas1.enabled = false;
    }

}