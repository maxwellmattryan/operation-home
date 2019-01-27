using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Transform gun;

    void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    StartCoroutine(shot(1000));
        //   // gun.transform.Translate(Vector3.back);
           
        //}
        bullet.transform.Translate(Vector3.up * Time.deltaTime * speed);
        
    }

    //IEnumerator shot(float timeInSeconds)
    //{
    //    gun.transform.Translate(Vector3.down);
    //    yield return new WaitForSeconds(timeInSeconds);
    //    gun.transform.Translate(Vector3.down);
    //}

}
