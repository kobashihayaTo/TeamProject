using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpotLightManeger : MonoBehaviour
{

    public float SpotTimer; //変数
    public Text spottext;
  
    void Start()
    {
        SpotTimer = 0.0f;
    }


    void Update()
    {
        spottext.text = string.Format("{0}", SpotTimer);  //Textのフォーマット
    }
}
