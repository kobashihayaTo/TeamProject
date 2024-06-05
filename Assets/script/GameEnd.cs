using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    
    void Update()
    {
        //エスケープを押したらゲームを終了
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
