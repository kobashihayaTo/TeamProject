using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_7 : MonoBehaviour
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
    bool spotlightFlag_7;

    //ライトの個数
    public float spotLightIntensity7_1;
    public float spotLightIntensity7_2;
    public float spotLightIntensity7_3;
    public float spotLightIntensity7_4;


    void Start()
    {
        spotlightFlag_7 = false;
    }

    void Update()
    {
        if (spotlightFlag_7 == true)
        {
            Debug.Log("あたった77");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;
        }

        if (spotlight1.intensity >= spotLightIntensity7_1)
        {
            spotlight1.intensity = spotLightIntensity7_1;
        }

        if (spotlight2.intensity >= spotLightIntensity7_2)
        {
            spotlight2.intensity = spotLightIntensity7_2;
        }

        if (spotlight3.intensity >= spotLightIntensity7_3)
        {
            spotlight3.intensity = spotLightIntensity7_3;
        }

        if (spotlight4.intensity >= spotLightIntensity7_4)
        {
            spotlight4.intensity = spotLightIntensity7_4;
        }
    }

    public void SetspotlightFlag_7(bool spotlightFlag_7)
    {
        this.spotlightFlag_7 = spotlightFlag_7;
    }


}
