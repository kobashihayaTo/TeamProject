using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter_Player : MonoBehaviour
{
    public RepairTimerManger RepairManger;

    private int Status;  //�������ł������ǂ����𔻒f����ϐ�

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
        }
        if (collision.gameObject.name == "battery-2")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer2 += 1;  //�X�R�A���Z���Ă�������

            }
        }
        if (collision.gameObject.name == "battery-3")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer3 += 1;  //�X�R�A���Z���Ă�������

            }
        }
        if (collision.gameObject.name == "battery-4")
        {
            Debug.Log("��������!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //�X�R�A���Z���Ă�������

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
    }

    // Start is called before the first frame update
    void Start()
    {
        Status = 0;  //0��������Cllision��if�������s�����
    }

}