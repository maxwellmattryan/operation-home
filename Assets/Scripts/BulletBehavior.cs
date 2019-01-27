using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    public bool play_shoot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            play_shoot = true;
            Shoot();
        } 
    }

    void Shoot()
    {
        Instantiate(bullet, player.transform.position, player.transform.rotation);
    }
}
