using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 CameraSecondpos;
    public Vector3 CameraFirstpos;

    public void CameraMoveTrigger_Second()
    {
        Debug.Log("�ς����");
        transform.position = CameraSecondpos;
    }

    public void CameraMoveTrigger_First()
    {
        Debug.Log("�ς����");
        transform.position = CameraFirstpos;
    }
}
