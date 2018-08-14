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
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("EulerAngles: " + transform.localEulerAngles);
            Debug.Log("Rotation: " + transform.localRotation);
            transform.localEulerAngles += new Vector3(0, 180, 0);
            Debug.Log("EulerAngles: " + transform.localEulerAngles);
            //Debug.Log("Position: " + transform.localPosition);
            Debug.Log("Rotation: " + transform.localRotation);
            //Debug.Log("Scale: " + transform.localScale);
        }*/
        Death();
	}

    public void MovingForward() {
        //松开摇杆之后按照当前方向移动
        transform.position += Speed * transform.forward * Time.deltaTime;   
    }
    
    

}
