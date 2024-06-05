using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class SpotLightScript : MonoBehaviour
{
    //バッテリーの個数に応じて増やす
    [SerializeField]
    Light spotlight1;
    [SerializeField]
    Light spotlight2;
    [SerializeField]
    Light spotlight3;

    //バッテリーの個数に応じて増やす
    bool spotlightFlag_1;

    //ライトの個数
    public float spotLightIntensity1_1;
    public float spotLightIntensity1_2;
    public float spotLightIntensity1_3;

    void Start()
    {
        spotlightFlag_1 = false;
    }

    void Update()
    {
        if (spotlightFlag_1 == true) 
        {
            Debug.Log("あたった");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            
        }

        if (spotlight1.intensity >= spotLightIntensity1_1) 
        {
            spotlight1.intensity = spotLightIntensity1_1;
        }
        if (spotlight2.intensity >= spotLightIntensity1_2)
        {
            spotlight2.intensity = spotLightIntensity1_2;
        }
        if (spotlight3.intensity >= spotLightIntensity1_3)
        {
            spotlight3.intensity = spotLightIntensity1_3;
        }

    }

    public void SetspotlightFlag(bool spotlightFlag_1)
    {
        this.spotlightFlag_1 = spotlightFlag_1;
    }

    
}
