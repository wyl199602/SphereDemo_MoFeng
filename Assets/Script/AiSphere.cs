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
        ChangeForward(new Vector3(0, Random.Range(0, 360), 0));
    }

    //定时产生一个随机方向，让小球改变方向，小球总是朝着当前方向移动
    Quaternion RandomForward() {
        Vector3 scale = new Vector3(0, Random.Range(0, 360), 0);
        Quaternion rotation = Quaternion.Euler(scale);
        return rotation;
    }

    //修改移动方向(随机、目标、反方向)
    void ChangeForward(Vector3 rotation) {
        timeCount += Time.deltaTime;
       if (timeCount >= TimeUpdateForward)
       {           
            transform.localEulerAngles = rotation;
            timeCount = 0;
        }
    }

    //触发？在边缘反方向移动
    Vector3 ChangeForwardBack() {
        Debug.Log("反方向");
        return transform.localEulerAngles += new Vector3(0, 180, 0);
    }

    //Plus：主动攻击别的小球
    void Attack() {
        //定时寻找小球
        //追击小球
        //更新追击目标？是撞击几次还是经过时间？
    }

    // 开始接触
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("开始接触： " + collider.name);
        ChangeForward(ChangeForwardBack());
    }
    // 接触结束
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("接触结束： " + collider.name);     
    }
    // 接触持续中
    void OnTriggerStay(Collider collider)
    {
        Debug.Log("接触持续中： " + collider.name);
    }


}
