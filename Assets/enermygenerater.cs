using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermygenerater : MonoBehaviour
{
    public GameObject bulletprefab;
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if(time>0.5)
        {
            GameObject bullet = Instantiate(bulletprefab, transform.position, transform.rotation);
            bullet.GetComponent<BulletController>().shotEnemy();

            time = 0f;
        }

    }
   

}
