using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    public GameObject bullet;

    void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        bullet.transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
