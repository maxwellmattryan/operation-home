using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public GameObject enemy;

    void Start()
    {
        Destroy(gameObject, 1);

    }

   
    void Update()
    {
        bullet.transform.Translate(Vector3.up * Time.deltaTime * speed);
        
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "Enemy")
    //    {
    //        Destroy(bullet);
    //        Destroy(enemy);
    //    }
    //}

}
