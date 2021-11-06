using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //定义玩家速度
    public float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");              //控制水平移动 A=-1 D=1 Null=0
        float moveY = Input.GetAxisRaw("Vertical");                 //控制垂直移动 S=-1 W=1 Null=0

        //获得当前组件的位置
        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;              //水平方向位置变化
        position.y += moveY * speed * Time.deltaTime;              //垂直方向位置变化
        //把位置信息赋值给当前组件
        transform.position = position;
    }
}
