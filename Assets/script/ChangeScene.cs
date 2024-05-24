using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Timer++;

        if (Timer >= 10)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene");
                Timer = 0;
            }
        }
        

    }
}
