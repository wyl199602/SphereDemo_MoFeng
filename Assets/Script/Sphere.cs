using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    public float DeathDistance = 1.0f;
    public float Speed = 5.0f;
    //死亡
    public void Death()
    {
        if ((transform.position.y + DeathDistance) < 0) {
            //1.向碰撞者发送消息（分数增加（player），变大）
            //TODO
            //2.销毁自身
            GameObject.Destroy(this.gameObject);
        }
    }
    

    //变大

    //碰撞者的改变

}
