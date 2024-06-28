using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChangeScript : MonoBehaviour
{
    [SerializeField]
    Material[] materialArray = new Material[2];

    Material changeMaterial;

    

    public int setCount;
    int count = 0;
    int colorCount;

    void Start()
    {
        count = 0;
        colorCount = 0;
    }

    void Update()
    {

        // �}�E�X�̍��N���b�N������������count�𑝉�������
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            count++;
            
            if (count > 2)
            {
                count = 2;
            }
            Debug.Log(count);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count--;

            if (count < 0) 
            {
                count = 0;
            }
            Debug.Log(count);
        }

        //�X�e�[�W�I����ʂ̃{�b�N�X�̐F��ς���
        if(count == setCount)
        {
            colorCount = 1;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }
        else
        {
            //����ȊO�Ȃ甒�ɂ���
            colorCount = 0;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }

        if (count == setCount)
        {
            //count��1�Ȃ獶�̃{�b�N�X��Ԃɕς���
            colorCount = 1;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }
        else
        {
            //����ȊO�Ȃ甒�ɂ���
            colorCount = 0;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }

        if (count == setCount)
        {
            //count��2�Ȃ獶�̃{�b�N�X��Ԃɕς���
            colorCount = 1;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }
        else
        {
            //����ȊO�Ȃ甒�ɂ���
            colorCount = 0;

            //count��0�Ȃ獶�̃{�b�N�X��Ԃɕς���
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
           if(count==0)
            {
                SceneManager.LoadScene("Stage1Scene");
            }
           else if(count==1)
            {

            }
           else if(count==2)
            {

            }
        }
    }
}
