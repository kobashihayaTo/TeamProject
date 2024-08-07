using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_4 : MonoBehaviour
{

    //バッテリーの個数に応じて増やす
    [SerializeField]
    Light spotlight1;
    [SerializeField]
    Light spotlight2;
    [SerializeField]
    Light spotlight3;
    [SerializeField]
    Light spotlight4;

    //バッテリーの個数に応じて増やす
    bool spotlightFlag_4;

    //ライトの個数
    public float spotLightIntensity4_1;
    public float spotLightIntensity4_2;
    public float spotLightIntensity4_3;
    public float spotLightIntensity4_4;

    void Start()
    {
        spotlightFlag_4 = false;
    }

    void Update()
    {
        if (spotlightFlag_4 == true)
        {
            Debug.Log("あたった77");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;           
        }

        if (spotlight1.intensity >= spotLightIntensity4_1)
        {
            spotlight1.intensity = spotLightIntensity4_1;
        }

        if (spotlight2.intensity >= spotLightIntensity4_2)
        {
            spotlight2.intensity = spotLightIntensity4_2;
        }

        if (spotlight3.intensity >= spotLightIntensity4_3)
        {
            spotlight3.intensity = spotLightIntensity4_3;
        }

        if (spotlight4.intensity >= spotLightIntensity4_4)
        {
            spotlight4.intensity = spotLightIntensity4_4;
        }
    }

    public void SetspotlightFlag_4(bool spotlightFlag_4)
    {
        this.spotlightFlag_4 = spotlightFlag_4;
    }


}
