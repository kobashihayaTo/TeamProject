using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SearchCollision : MonoBehaviour
{
    //�������Ă��邩�̃t���O
    private bool searchFlag;

    //false�ɂȂ�܂ł̃^�C�}�[
    private int falseTimer;

    // Start is called before the first frame update
    void Start()
    {
        searchFlag = false;
        falseTimer = 0;
    }

    void Update()
    {
        if(searchFlag==true)
        {
            falseTimer--;
            if (falseTimer <= 3000)
            {
                Debug.Log("����");
            }
        }


        if (falseTimer <= 0 && searchFlag == true) 
        {
            //����ȊO�̈ȊO�̏ꍇ��searchFlag��false�ɂ���
            Debug.Log("false");
            searchFlag = false;
        }
    }

    //�Ώۂ��G��Ă���Ԃ̏���
    private void OnTriggerEnter(Collider collider)
    {

        //���������Ώۂ��v���C���[�������ꍇ
        if (collider.gameObject.tag == "Player")
        {
            //seachFlag��true�ɂ���
            Debug.Log("true");
            searchFlag = true;
            falseTimer = 6000;
        }

        
    }

    //searchFlag�̃Q�b�^�[
    public bool GetSearchFlag()
    {
        return searchFlag;
    }
}
