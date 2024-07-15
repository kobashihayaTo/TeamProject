using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_6 : MonoBehaviour
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
    bool spotlightFlag_6;

    //ライトの個数
    public float spotLightIntensity6_1;
    public float spotLightIntensity6_2;
    public float spotLightIntensity6_3;
    public float spotLightIntensity6_4;

    void Start()
    {
        spotlightFlag_6 = false;
    }

    void Update()
    {
        if (spotlightFlag_6 == true)
        {
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;
        }

        if (spotlight1.intensity >= spotLightIntensity6_1)
        {
            spotlight1.intensity = spotLightIntensity6_1;
        }

        if (spotlight2.intensity >= spotLightIntensity6_2)
        {
            spotlight2.intensity = spotLightIntensity6_2;
        }

        if (spotlight3.intensity >= spotLightIntensity6_3)
        {
            spotlight3.intensity = spotLightIntensity6_3;
        }

        if (spotlight4.intensity >= spotLightIntensity6_4)
        {
            spotlight4.intensity = spotLightIntensity6_4;
        }
    }

    public void SetspotlightFlag_6(bool spotlightFlag_6)
    {
        this.spotlightFlag_6 = spotlightFlag_6;
    }


}
