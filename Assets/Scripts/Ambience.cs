using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    public float pitchRise;

    public AudioClip clip_ambience;
    AudioSource source_ambience;

    private static Ambience _instance;

    public static Ambience instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<Ambience>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    private void Awake()
    {
        source_ambience = GetComponent<AudioSource>();

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
            {
                source_ambience.Play();
                Destroy(this.gameObject);
            }
        }
    }

    void IncreasePitch()
    {
        source_ambience.pitch += pitchRise;
    }
}
