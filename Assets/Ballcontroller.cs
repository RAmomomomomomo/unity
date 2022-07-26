using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontroller : MonoBehaviour
{

    private Rigidbody ballRD;
    public float speed = 10.0f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        ballRD = GetComponent<Rigidbody>();
        ballRD.AddForce(-speed, 0, -speed * 0.7f);
        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = collision.transform.position;
            Vector3 incomVec = currPos - startPos;//입사각
            Vector3 normalVec=collision.contacts[0].normal;//법선벡터(공식이라네요) 수직벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec=reflectVec.normalized;//반사각 정규화

            ballRD.AddForce(reflectVec * speed); //이게 공을 튕겨냄
        }
        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;
            Vector3 incomVec = currPos - startPos;//입사각
            Vector3 normalVec = collision.contacts[0].normal;//법선벡터(공식이라네요) 수직벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized;//반사각 정규화

            ballRD.AddForce(reflectVec * speed);

            //충돌된 해당블럭 제거 
            Destroy(collision.gameObject);
        }

        startPos = transform.position;
    }
}
