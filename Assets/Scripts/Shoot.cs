﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    public GameObject bullet;

    FMOD.Studio.EventInstance sound_shoot;
    [FMODUnity.EventRef]
    public string sound_shoot_path;

    void Start()
    {
        sound_shoot = FMODUnity.RuntimeManager.CreateInstance(sound_shoot_path);
        sound_shoot.start();
        Destroy(gameObject, 1);
    }

    void Update()
    {
        bullet.transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
