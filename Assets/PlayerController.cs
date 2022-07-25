using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;

    // ������ ó�� ����ɶ�
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    //������ ����ɶ� �� �����Ӻ��� ȣǮ
    void Update()
    {
       // print("Update");

        //if(Input.GetKey(KeyCode.RightArrow)==true)
        //{
        //    //vector3 Ÿ���� ������ ����� �ӵ��� ������ ������Ʈ�� �̵��Ҽ� �ִ�
        //    //deltatime�� ��ǻ���� ���ɿ� ���� ������ �ӵ��� �����ϵ��� ������ �ð� ������ ����ȭ ��Ű�� ��
        //    transform.Translate(Vector3.right * speed * Time.deltaTime);

        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);

        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    transform.Translate(Vector3.back * speed * Time.deltaTime);

        //}
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //}
        //if (Input.GetKey(KeyCode.Space) == true)
        //{
        //    transform.Translate(Vector3.up * speed * Time.deltaTime);

        //}
        if (Input.GetKey(KeyCode.D) == true)
        {
            playerRd.AddForce(speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            playerRd.AddForce(-speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            playerRd.AddForce( 0f, 0f,speed);

        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            playerRd.AddForce( 0f, 0f,-speed);

        }
        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRd.AddForce(0f,speed, 0f );

        }

    }
}

