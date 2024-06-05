using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript_2 : MonoBehaviour
{
    //�o�b�e���[�̌��ɉ����đ��₷
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

    //�o�b�e���[�̌��ɉ����đ��₷
    bool spotlightFlag_2;

    //���C�g�̌�
    public float spotLightIntensity2_1;
    public float spotLightIntensity2_2;
    public float spotLightIntensity2_3;
    public float spotLightIntensity2_4;
    public float spotLightIntensity2_5;

    void Start()
    {
        spotlightFlag_2 = false;
    }

    void Update()
    {
        if (spotlightFlag_2 == true)
        {
            Debug.Log("��������77");
            spotlight1.intensity += 0.5f;
            spotlight2.intensity += 0.01f;
            spotlight3.intensity += 0.01f;
            spotlight4.intensity += 0.01f;
            spotlight5.intensity += 0.01f;
        }

        if (spotlight1.intensity >= spotLightIntensity2_1)
        {
            spotlight1.intensity = spotLightIntensity2_1;
        }

        if (spotlight2.intensity >= spotLightIntensity2_2)
        {
            spotlight2.intensity = spotLightIntensity2_2;
        }

        if (spotlight3.intensity >= spotLightIntensity2_3)
        {
            spotlight3.intensity = spotLightIntensity2_3;
        }

        if (spotlight4.intensity >= spotLightIntensity2_4)
        {
            spotlight4.intensity = spotLightIntensity2_4;
        }

        if (spotlight5.intensity >= spotLightIntensity2_5)
        {
            spotlight5.intensity = spotLightIntensity2_5;
        }
    }

    public void SetspotlightFlag_2(bool spotlightFlag_2)
    {
        this.spotlightFlag_2 = spotlightFlag_2;
    }


}
