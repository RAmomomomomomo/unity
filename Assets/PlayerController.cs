using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRd;
    public float speed = 10.0f;
    
    // 게임이 처음 실행될때
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    //게임이 실행될때 각 프레임별로 호풀
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRd.AddForce(-speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRd.AddForce(speed, 0,0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRd.AddForce(0, 0,speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRd.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

























        // print("Update");

        //if(Input.GetKey(KeyCode.RightArrow)==true)
        //{
        //    //vector3 타입은 벡터의 방향과 속도를 가지고 오브젝트를 이동할수 있다
        //    //deltatime은 컴퓨터의 성능에 따라 프레임 속도를 일정하도록 프레임 시간 간격을 동기화 시키는 값
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
        //if (Input.GetKey(KeyCode.D) == true)
        //{
        //    playerRd.AddForce(speed, 0f, 0f);

        //}
        //if (Input.GetKey(KeyCode.A) == true)
        //{
        //    playerRd.AddForce(-speed, 0f, 0f);

        //}
        //if (Input.GetKey(KeyCode.W) == true)
        //{
        //    playerRd.AddForce( 0f, 0f,speed);

        //}
        //if (Input.GetKey(KeyCode.S) == true)
        //{
        //    playerRd.AddForce( 0f, 0f,-speed);

        //}
        //if (Input.GetKey(KeyCode.Space) == true)
        //{
        //    playerRd.AddForce(0f,speed, 0f );

        //}

    }
   


}

