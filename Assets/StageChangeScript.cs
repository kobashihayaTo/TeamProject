using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StageChangeScript : MonoBehaviour
{
    //ゲーム画面のUI
    //[SerializeField] CanvasGroup grInfo;
    //メニュー画面のUI
    //[SerializeField] CanvasGroup grMenu;
    //四角のTransform
    [SerializeField] Transform squareA;
    [SerializeField] Transform squareB;
    [SerializeField] Transform squareC;
    //マスクのTransform
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

        // マウスの左クリックを押した時にcountを増加させる
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

        //ステージ選択画面のボックスの色を変える
        if (count == setCount)
        {
            colorCount = 1;

            //countが0なら左のボックスを赤に変える
            GetComponent<MeshRenderer>().material = materialArray[colorCount];
        }
        else
        {
            //それ以外なら白にする
            colorCount = 0;

            //countが0なら左のボックスを赤に変える
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
