using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiSphere : Sphere
{
    public float TimeUpdateForward = 1.0f;
    private float timeCount = 0f;



    private void Update()
    {
        Moving();
        //定时获取一个追击目标
        Death();
    }

    ///TODO
    //自动移动-Update
    void Moving() {
        transform.position = transform.position + Speed * transform.forward * Time.deltaTime;
        ChangeForward();
    }


    //修改移动方向(随机、目标)
    void ChangeForward() {
        timeCount += Time.deltaTime;
       if (timeCount >= TimeUpdateForward)
       {           
            transform.localEulerAngles = new Vector3(0, Random.Range(0, 360), 0); ;
            timeCount = 0;
        }
    }

    //触发？在边缘反方向移动
    Vector3 ChangeForwardBack() {
        Vector3 eulerAngles = transform.localEulerAngles;
        //Debug.Log(name + "  方向:" + eulerAngles);
        eulerAngles += new Vector3(0, 180, 0);
        //Debug.Log(name + "  反方向" + eulerAngles);
        transform.localEulerAngles = eulerAngles;
        return eulerAngles;
    }
     
    //Plus：主动攻击别的小球
    void Attack() {
        //定时寻找小球
        //追击小球
        //更新追击目标？是撞击几次还是经过时间？
    }

    
    void OnTriggerEnter(Collider collider)
    {
        // 开始接触
        //Debug.Log(name+"  开始接触： " + collider.name);
        ChangeForwardBack();
    }
    
    void OnTriggerExit(Collider collider)
    {
        // 接触结束
        //Debug.Log(name + "  接触结束： " + collider.name);     
    }
    
    void OnTriggerStay(Collider collider)
    {
        // 接触持续中
        //Debug.Log(name + "  接触持续中： " + collider.name);
    }


}
