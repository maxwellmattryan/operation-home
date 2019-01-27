using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    AudioSource sound_shootSource;

    void Start()
    {
        sound_shootSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sound_shootSource.Play();
            Shoot();
        } 
    }

    void Shoot()
    {
        Instantiate(bullet, player.transform.position, player.transform.rotation);
    }
}
