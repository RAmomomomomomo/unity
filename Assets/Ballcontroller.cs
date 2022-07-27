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
            Vector3 incomVec = currPos - startPos;//�Ի簢
            Vector3 normalVec=collision.contacts[0].normal;//��������(�����̶�׿�) ��������
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec=reflectVec.normalized;//�ݻ簢 ����ȭ

            ballRD.AddForce(reflectVec * speed); //�̰� ���� ƨ�ܳ�
        }
        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;
            Vector3 incomVec = currPos - startPos;//�Ի簢
            Vector3 normalVec = collision.contacts[0].normal;//��������(�����̶�׿�) ��������
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized;//�ݻ簢 ����ȭ

            ballRD.AddForce(reflectVec * speed);

            //�浹�� �ش���� ���� 
            Destroy(collision.gameObject);
        }

        startPos = transform.position;
    }
}