using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    
    void Update()
    {
        //�G�X�P�[�v����������Q�[�����I��
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
