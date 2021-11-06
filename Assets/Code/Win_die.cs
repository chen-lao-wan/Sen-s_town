using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_die : MonoBehaviour
{
    //定义开关和生命
    public bool Switch = false;
    public int Life = 3;
    // Update is called once per frame
    void Update()
    {
        //获取玩家位置
        Vector2 position = transform.position; 
        if (Switch == true && position.y <= -10 && Life >= 1)
        {
        //返回出生点并减1生命
        position.y = 0.5f;
        position.x = -2;
        transform.position = position;
         Life--;
        }
        else if(Switch == true && position.y <= -10 && Life <= 0)       //如果血量不足
        {
            SceneManager.LoadScene("GameOver");     //返回GameOver场景
        }
    }
    //当触发触发器时(退出游戏)
    private void OnTriggerEnter2D(Collider2D collision)     //设置触发器
    {
        if (collision.name== "Finish")//如果触发了Finish组件
        {
#if UNITY_EDITOR//如果在编译器中
            UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_ANDROID||UNITY_STANDALONE_WIN//如果在Windows或安卓中
            Application.Quit();
#endif
            Life++;
        }
    }
}
