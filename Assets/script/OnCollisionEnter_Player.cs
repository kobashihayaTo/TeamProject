using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;

//�I���R���W�����̏���
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
    //�X�e�[�W�̃X�|�b�g���C�g
    [SerializeField]
    public Light StageLight_1;

    //�o�b�e���[�̃X�|�b�g���C�g
    [SerializeField]
    public Light BatteryLight_1;
    [SerializeField]
    public Light BatteryLight_2;
    [SerializeField]
    public Light BatteryLight_3;
    [SerializeField]
    public Light BatteryLight_4;
    [SerializeField]
    public Light BatteryLight_5;

    //HP��UI
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Canvas canvas1;
    //HP�ƃo�b�e���[�̃Q�[�W
    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;



    private int Status;  //�������ł������ǂ����𔻒f����ϐ�

    int battery1Flag = 0;
    int battery2Flag = 0;
    int battery3Flag = 0;
    int battery4Flag = 0;
    int battery5Flag = 0;

    void LightShine()
    {
        if (battery1Flag == 1 && battery2Flag == 1 && battery3Flag == 1 && battery4Flag == 1 )
        {
            StageLight_1.intensity = 50;
        }

        if (battery1Flag == 1) 
        {
            BatteryLight_1.intensity = 5;
        }
        if (battery2Flag == 1)
        {
            BatteryLight_2.intensity = 5;
        }
        if (battery3Flag == 1)
        {
            BatteryLight_3.intensity = 5;
        }
        if (battery4Flag == 1)
        {
            BatteryLight_4.intensity = 5;
        }
        if (battery5Flag == 1)
        {
            BatteryLight_5.intensity = 5;
        }
    }

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

    //�o�b�e���[�̓����蔻��
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
            //Debug.Log("��������!");
            
        }
        #endregion
        ClearScene();
        LightShine();
    }
    //�G�Ƃ̓����蔻��
    private void OnTriggerStay(Collider other)
    {
        #region enemy

        if (other.gameObject.tag == "enemy")
        {
            OverScene();
        }

        #endregion
    }
    //���̊K�w�s���Ƃ��̃Q�[�W
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