using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_die : MonoBehaviour
{
    //���忪�غ�����
    public bool Switch = false;
    public int Life = 3;
    // Update is called once per frame
    void Update()
    {
        //��ȡ���λ��
        Vector2 position = transform.position; 
        if (Switch == true && position.y <= -10 && Life >= 1)
        {
        //���س����㲢��1����
        position.y = 0.5f;
        position.x = -2;
        transform.position = position;
         Life--;
        }
        else if(Switch == true && position.y <= -10 && Life <= 0)       //���Ѫ������
        {
            SceneManager.LoadScene("GameOver");     //����GameOver����
        }
    }
    //������������ʱ(�˳���Ϸ)
    private void OnTriggerEnter2D(Collider2D collision)     //���ô�����
    {
        if (collision.name== "Finish")//���������Finish���
        {
#if UNITY_EDITOR//����ڱ�������
            UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_ANDROID||UNITY_STANDALONE_WIN//�����Windows��׿��
            Application.Quit();
#endif
            Life++;
        }
    }
}
