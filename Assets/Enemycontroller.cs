using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    float rightMax = 4f;
    float leftMax = -4f;
    float currentPosition = 0f;
    float speed = 3f;



    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition += Time.deltaTime * speed;

        if (currentPosition>=rightMax)
        {
            currentPosition = rightMax;
            speed *= -1;
        }
        else if(currentPosition<=leftMax)
        {
            currentPosition=leftMax;
            speed *= -1;
        }

        transform.position = new Vector3(currentPosition, 1, 4.5f);
    }
    private void OnCollisionEnter(Collision collision) //충돌이벤트
    {
        if (collision.gameObject.CompareTag("BULLET"))
        {
            Destroy(gameObject);
        }
    }
 
}
