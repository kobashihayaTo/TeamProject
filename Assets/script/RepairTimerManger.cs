using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RepairTimerManger : MonoBehaviour
{

    public int RepairTimer = 0; //�ϐ�
    public int RepairTimer2 = 0; //�ϐ�
    public int RepairTimer3 = 0; //�ϐ�

    public Text repair;
    public Text repair2;
    public Text repair3;

    // ������
    void Start()
    {
        RepairTimer = 0;
        RepairTimer2 = 0;
        RepairTimer3 = 0;
    }
    // �X�V
    void Update()
    {
        repair.text = string.Format("{0}", RepairTimer);  //Text�̃t�H�[�}�b�g
        repair2.text = string.Format("{0}", RepairTimer2);  //Text�̃t�H�[�}�b�g
        repair3.text = string.Format("{0}", RepairTimer3);  //Text�̃t�H�[�}�b�g
    }

}
