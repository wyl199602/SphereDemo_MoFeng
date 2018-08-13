using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : Sphere
{
    //分数增加
    //控制（EasyTouch）

	void Start () {
		
	}
	
	void Update () {
        /*
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("EulerAngles: " + transform.localEulerAngles);
            Debug.Log("Position: " + transform.localPosition);
            Debug.Log("Rotation: " + transform.localRotation);
            Debug.Log("Scale: " + transform.localScale);
        }*/
        Death();
	}
    

}
