using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5.0f;
    Rigidbody rb;

    [SerializeField]
    LightMove lightmove;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();  // rigidbodyを取得 
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.zero;

        if (lightmove.GetLightFlag() == false) 
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 10.0f); // 値を設定
                                                              //transform.position += speed * transform.forward * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector3(0.0f, 0.0f, -10.0f); // 値を設定
                                                               //transform.position -= speed * transform.forward * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector3(-10.0f, 0.0f, 0.0f); // 値を設定
                                                               //transform.position -= speed * transform.right * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector3(10.0f, 0.0f, 0.0f); // 値を設定
                                                              //transform.position += speed * transform.right * Time.deltaTime;
            }

        }
    }
}
