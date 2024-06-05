using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisionEnter_Player : MonoBehaviour
{
    public RepairTimerManger RepairManger;

    [SerializeField]
    public SpotLightScript spotLightScript;
    [SerializeField]
    public SpotLightScript_2 spotLightScript_2;
    [SerializeField] 
    public SpotLightScript_3 spotLightScript_3;
    [SerializeField]
    public SpotLightScript_4 spotLightScript_4;

    private int Status;  //�������ł������ǂ����𔻒f����ϐ�

    int battery1Flag = 0;
    int battery2Flag = 0;
    int battery3Flag = 0;
    int battery4Flag = 0;

    void Scene()
    {
        if (battery1Flag == 1 && battery2Flag == 1 && battery3Flag == 1 && battery4Flag == 1) 
        {
            Debug.Log("�`�F���W");
            SceneManager.LoadScene("ClearScene");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        #region battery

        spotLightScript.SetspotlightFlag(false);
        spotLightScript_2.SetspotlightFlag_2(false);
        spotLightScript_3.SetspotlightFlag_3(false);
        spotLightScript_4.SetspotlightFlag_4(false);

        
        if (collision.gameObject.name == "battery-1")
        {
            spotLightScript.SetspotlightFlag(true);

            //Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������
                
            }

            if (RepairManger.RepairTimer > 100) 
            {
                battery1Flag = 1;
                RepairManger.RepairTimer = 100;
            }
        }
        if (collision.gameObject.name == "battery-2")
        {
            spotLightScript_2.SetspotlightFlag_2(true);
            if (Status == 0)
            {
                RepairManger.RepairTimer2 += 1;  //�X�R�A���Z���Ă�������
                if (RepairManger.RepairTimer2 > 100)
                {
                    battery2Flag = 1;
                    RepairManger.RepairTimer2 = 100;
                }
            }
        }
        if (collision.gameObject.name == "battery-3")
        {
            spotLightScript_3.SetspotlightFlag_3(true);
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer3 += 1;  //�X�R�A���Z���Ă�������

            }
            if (RepairManger.RepairTimer3 > 100)
            {
                battery3Flag = 1;
                RepairManger.RepairTimer3 = 100;
            }
        }
        if (collision.gameObject.name == "battery-4")
        {
            spotLightScript_4.SetspotlightFlag_4(true);
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer4 += 1;  //�X�R�A���Z���Ă�������

            }
            if (RepairManger.RepairTimer4 > 100)
            {
                battery4Flag = 1;
                RepairManger.RepairTimer4 = 100;
            }
        }
        if (collision.gameObject.name == "battery-5")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������

            }
        }
        if (collision.gameObject.name == "battery-6")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������

            }
        }
        #endregion

        #region enemy

        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("���񂿂傱���傱���傱�ҁ[!");
        }

            #endregion

            Scene();
    }



    // Start is called before the first frame update
    void Start()
    {
        Status = 0;  //0��������Cllision��if�������s�����
    }

}