using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RepairTimerManger : MonoBehaviour
{

    public int RepairTimer = 0; //変数
    public int RepairTimer2 = 0; //変数
    public int RepairTimer3 = 0; //変数

    public Text repair;
    public Text repair2;
    public Text repair3;

    // 初期化
    void Start()
    {
        RepairTimer = 0;
        RepairTimer2 = 0;
        RepairTimer3 = 0;
    }
    // 更新
    void Update()
    {
        repair.text = string.Format("{0}", RepairTimer);  //Textのフォーマット
        repair2.text = string.Format("{0}", RepairTimer2);  //Textのフォーマット
        repair3.text = string.Format("{0}", RepairTimer3);  //Textのフォーマット
    }

}
