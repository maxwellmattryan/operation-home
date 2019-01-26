using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        } 
    }

    void shoot()
    {
        Instantiate(bullet, player.transform.position, player.transform.rotation);
    }
}
