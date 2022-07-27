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
    private void OnCollisionEnter(Collision collision) //�浹�̺�Ʈ
    {
        if (collision.gameObject.CompareTag("BULLET"))
        {
            Destroy(gameObject);
        }
    }//�Ҹ��� ���̶� �÷��̾ �����ϴ°� �˻��Ұ� �ʹ������ϱ�
    //�׳� ��� ��ü�� �Ҹ��� �¾Ҵ��� �Ǵ��ϴ°� ������ 
    //�̷����� �������� ����

    private void OnEnable()
    {
        Destroy(gameObject, 1f);
    }
}
