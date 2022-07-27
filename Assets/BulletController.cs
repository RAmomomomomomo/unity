using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    //private Rigidbody BulletRd;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
       // BulletRd=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    shot();
        //}
    }
    public void shot()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, speed); 
    }
    public void shotEnemy()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, -speed); ;
    }

    private void OnEnable()
    {
        Destroy(gameObject, 1f);
    }

}
