using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    public float pitchRise;

    public AudioClip clip_ambience;
    AudioSource source_ambience;

    void Start()
    {
        source_ambience = GetComponent<AudioSource>();
    }

    void Update()
    {
        // IF ENEMY KILLED, INCREASE PITCH
        IncreasePitch();
    }

    void IncreasePitch()
    {
        source_ambience.pitch += pitchRise;
    }
}
