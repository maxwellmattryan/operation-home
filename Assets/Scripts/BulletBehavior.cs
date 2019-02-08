using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject camera;

    AudioSource sound_shootSource;

    void Start()
    {
        sound_shootSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        } 
    }

    void Shoot()
    {
        sound_shootSource.Play();
        Instantiate(bullet, player.transform.position, player.transform.rotation);
        camera.GetComponent<ShakeBehavior>().TriggerShake();
    }
}
