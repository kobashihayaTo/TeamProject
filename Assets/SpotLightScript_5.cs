using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_5 : MonoBehaviour
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
    bool spotlightFlag_5;

    //ライトの個数
    public float spotLightIntensity5_1;
    public float spotLightIntensity5_2;
    public float spotLightIntensity5_3;
    public float spotLightIntensity5_4;
    public float spotLightIntensity5_5;

    void Start()
    {
        spotlightFlag_5 = false;
    }

    void Update()
    {
        if (spotlightFlag_5 == true)
        {
            Debug.Log("あたった77");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;
            spotlight5.intensity += 0.01f;
        }

        if (spotlight1.intensity >= spotLightIntensity5_1)
        {
            spotlight1.intensity = spotLightIntensity5_1;
        }

        if (spotlight2.intensity >= spotLightIntensity5_2)
        {
            spotlight2.intensity = spotLightIntensity5_2;
        }

        if (spotlight3.intensity >= spotLightIntensity5_3)
        {
            spotlight3.intensity = spotLightIntensity5_3;
        }

        if (spotlight4.intensity >= spotLightIntensity5_4)
        {
            spotlight4.intensity = spotLightIntensity5_4;
        }

        if (spotlight5.intensity >= spotLightIntensity5_5)
        {
            spotlight5.intensity = spotLightIntensity5_5;
        }
    }

    public void SetspotlightFlag_5(bool spotlightFlag_5)
    {
        this.spotlightFlag_5 = spotlightFlag_5;
    }


}
