using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpotLightManeger : MonoBehaviour
{

    public int SpotTimer = 0; //変数
    public Text spottext;
    // Start is called before the first frame update
    void Start()
    {
        SpotTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spottext.text = string.Format("{0}", SpotTimer);  //Textのフォーマット
    }
}
