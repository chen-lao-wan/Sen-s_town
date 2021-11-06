using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //��������ٶ�
    public float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");              //����ˮƽ�ƶ� A=-1 D=1 Null=0
        float moveY = Input.GetAxisRaw("Vertical");                 //���ƴ�ֱ�ƶ� S=-1 W=1 Null=0

        //��õ�ǰ�����λ��
        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;              //ˮƽ����λ�ñ仯
        position.y += moveY * speed * Time.deltaTime;              //��ֱ����λ�ñ仯
        //��λ����Ϣ��ֵ����ǰ���
        transform.position = position;
    }
}
