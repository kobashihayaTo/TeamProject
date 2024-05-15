using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 Firstpos;
    public Vector3 Secondpos;
    public CameraMove cameraMove;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "MoveFirstFloor") 
        {
            //Debug.Log("“–‚½‚Á‚½!");
            cameraMove.CameraMoveTrigger_Second();
            transform.position = new Vector3(Secondpos.x, Secondpos.y, Secondpos.z);
            
        }
        if (collider.gameObject.name == "MoveSecondFloor")
        {
            //Debug.Log("“–‚½‚Á‚½!");
            cameraMove.CameraMoveTrigger_First();
            transform.position = new Vector3(Firstpos.x, Firstpos.y, Firstpos.z);
        }
    }
}
