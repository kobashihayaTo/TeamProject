using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SearchCollision : MonoBehaviour
{
    //当たっているかのフラグ
    private bool searchFlag;

    //falseになるまでのタイマー
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
                Debug.Log("半分");
            }
        }


        if (falseTimer <= 0 && searchFlag == true) 
        {
            //それ以外の以外の場合はsearchFlagをfalseにする
            Debug.Log("false");
            searchFlag = false;
        }
    }

    //対象が触れている間の処理
    private void OnTriggerEnter(Collider collider)
    {

        //当たった対象がプレイヤーだった場合
        if (collider.gameObject.tag == "Player")
        {
            //seachFlagをtrueにする
            Debug.Log("true");
            searchFlag = true;
            falseTimer = 6000;
        }

        
    }

    //searchFlagのゲッター
    public bool GetSearchFlag()
    {
        return searchFlag;
    }
}
