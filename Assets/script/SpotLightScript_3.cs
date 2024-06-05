using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_3 : MonoBehaviour
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
    [SerializeField]
    Light spotlight5;

    //バッテリーの個数に応じて増やす
    bool spotlightFlag_3;

    //ライトの個数
    public float spotLightIntensity3_1;
    public float spotLightIntensity3_2;
    public float spotLightIntensity3_3;
    public float spotLightIntensity3_4;
    public float spotLightIntensity3_5;

    void Start()
    {
        spotlightFlag_3 = false;
    }

    void Update()
    {
        if (spotlightFlag_3 == true)
        {
            Debug.Log("あたった77");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;
            spotlight5.intensity += 0.01f;
        }

        if (spotlight1.intensity >= spotLightIntensity3_1)
        {
            spotlight1.intensity = spotLightIntensity3_1;
        }

        if (spotlight2.intensity >= spotLightIntensity3_2)
        {
            spotlight2.intensity = spotLightIntensity3_2;
        }

        if (spotlight3.intensity >= spotLightIntensity3_3)
        {
            spotlight3.intensity = spotLightIntensity3_3;
        }

        if (spotlight4.intensity >= spotLightIntensity3_4)
        {
            spotlight4.intensity = spotLightIntensity3_4;
        }

        if (spotlight5.intensity >= spotLightIntensity3_5)
        {
            spotlight5.intensity = spotLightIntensity3_5;
        }
    }

    public void SetspotlightFlag_3(bool spotlightFlag_3)
    {
        this.spotlightFlag_3 = spotlightFlag_3;
    }


}
