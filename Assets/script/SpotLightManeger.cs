using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpotLightManeger : MonoBehaviour
{

    public float SpotTimer; //�ϐ�
    public Text spottext;
  
    void Start()
    {
        SpotTimer = 0.0f;
    }


    void Update()
    {
        spottext.text = string.Format("{0}", SpotTimer);  //Text�̃t�H�[�}�b�g
    }
}
