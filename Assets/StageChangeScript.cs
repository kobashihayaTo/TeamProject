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
        if(count == setCount)
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

        if (count == setCount)
        {
            //countが1なら左のボックスを赤に変える
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

        if (count == setCount)
        {
            //countが2なら左のボックスを赤に変える
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
