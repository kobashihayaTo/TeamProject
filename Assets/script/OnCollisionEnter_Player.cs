using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter_Player : MonoBehaviour
{
    public RepairTimerManger RepairManger;

    private int Status;  //準備ができたかどうかを判断する変数

    void OnCollisionStay(Collision collision)
    {
        #region battery
        if (collision.gameObject.name == "battery-1")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //スコア加算していく数字
            }
        }
        if (collision.gameObject.name == "battery-2")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer2 += 1;  //スコア加算していく数字

            }
        }
        if (collision.gameObject.name == "battery-3")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer3 += 1;  //スコア加算していく数字

            }
        }
        if (collision.gameObject.name == "battery-4")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //スコア加算していく数字

            }
        }
        if (collision.gameObject.name == "battery-5")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //スコア加算していく数字

            }
        }
        if (collision.gameObject.name == "battery-6")
        {
            Debug.Log("当たった!");
            if (Status == 0)
            {
                RepairManger.RepairTimer += 1;  //スコア加算していく数字

            }
        }
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        Status = 0;  //0だったらCllisionのif文が実行される
    }

}