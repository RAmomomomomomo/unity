using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletgenerater : MonoBehaviour
{
    //프리펫 :재사용을 위한 오브젝트
    public GameObject bulletprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletprefab, transform.position, transform.rotation);
            bullet.GetComponent<BulletController>().shot();
        }
    }
}
