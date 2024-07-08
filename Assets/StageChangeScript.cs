using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StageChangeScript : MonoBehaviour
{
    //�Q�[����ʂ�UI
    //[SerializeField] CanvasGroup grInfo;
    //���j���[��ʂ�UI
    //[SerializeField] CanvasGroup grMenu;
    //�l�p��Transform
    [SerializeField] Transform squareA;
    [SerializeField] Transform squareB;
    [SerializeField] Transform squareC;
    //�}�X�N��Transform
    [SerializeField] Transform squareMesk;


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
        if (count == setCount)
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (count == 0)
            {
                ScreenTransition();
                SceneManager.LoadScene("Stage1Scene");
            }
            else if (count == 1)
            {
                ScreenTransition();
            }
            else if (count == 2)
            {
                ScreenTransition();
            }
        }
       // ScreenTransition();
    }

    private void ScreenTransition()
    {
        var sequence = DOTween.Sequence();
        sequence = DOTween.Sequence()
            .Append(squareA.DOLocalMoveX(0f, 2f))
            .Join(squareB.DOLocalMoveX(0f, 2f).SetDelay(0.5f))
            .Join(squareC.DOLocalMoveX(0f, 2f).SetDelay(0.5f))
            .Join(squareMesk.DOLocalMoveX(0f, 2f).SetDelay(0.5f))

            .AppendCallback(() =>
            {
                squareA.localPosition = new Vector3(-18f, 0f, 0f);
                squareB.localPosition = new Vector3(-18f, 0f, 0f);
                squareC.localPosition = new Vector3(-18f, 0f, 0f);
                squareMesk.localPosition = new Vector3(-18f, 0f, 0f);
            });
    }
}
