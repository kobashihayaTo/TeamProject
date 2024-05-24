using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class OnCollisionEnter_Player : MonoBehaviour
{
    public RepairTimerManger RepairManger;
    public Bloom bloom;
    public PostProcessVolume postVolume;

    private int Status;  //�������ł������ǂ����𔻒f����ϐ�

    int battery1Flag = 0;
    int battery2Flag = 0;
    int battery3Flag = 0;
    int battery4Flag = 0;

    void Scene()
    {
        if (battery1Flag == 1 && battery2Flag == 1 && battery3Flag == 1)
        {
            Debug.Log("�`�F���W");
            SceneManager.LoadScene("ClearScene");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        #region battery
        if (collision.gameObject.name == "battery-1")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������
                
            }

            if (RepairManger.RepairTimer > 100) 
            {
                battery1Flag = 1;
            }
        }
        if (collision.gameObject.name == "battery-2")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer2 += 1;  //�X�R�A���Z���Ă�������
                if (RepairManger.RepairTimer2 > 100)
                {
                    battery2Flag = 1;
                }
            }
        }
        if (collision.gameObject.name == "battery-3")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer3 += 1;  //�X�R�A���Z���Ă�������

            }
            if (RepairManger.RepairTimer3 > 100)
            {
                battery3Flag = 1;
            }
        }
        if (collision.gameObject.name == "battery-4")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������

            }
            if (RepairManger.RepairTimer > 100)
            {
                battery4Flag = 1;
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

        Scene();
    }



    // Start is called before the first frame update
    void Start()
    {
        Status = 0;  //0��������Cllision��if�������s�����
        bloom=GetComponent<Bloom>();
       
    }

}