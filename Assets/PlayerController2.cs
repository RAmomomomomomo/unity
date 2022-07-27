using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed =  10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision) //충돌이벤트
    {
        if (collision.gameObject.CompareTag("BULLET"))
        {
            Destroy(gameObject);
        }
    }//불릿이 적이랑 플레이어를 구분하는건 검사할게 너무많으니까
    //그냥 대상 자체가 불릿을 맞았는지 판단하는게 더빨라서 
    //이렇게함 이유없음 ㅅㄱ

    private void OnEnable()
    {
        Destroy(gameObject, 1f);
    }
}
