using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Earth;
    public float speed;

    AudioSource sound_playerRotateSource;
    public AudioClip sound_playerRotate_Head;
    public AudioClip sound_playerRotate_Body;
    public AudioClip sound_playerRotate_Tail;
    bool moveOneShot;

    void Start()
    {
        sound_playerRotateSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.RotateAround(Earth.transform.position, Vector3.back, speed * Time.deltaTime);
        }
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.RotateAround(Earth.transform.position, Vector3.forward, speed * Time.deltaTime);
        }
        
        // sounds conditionals
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            sound_playerRotateSource.PlayOneShot(sound_playerRotate_Head, 1.0f);
        }
        if ((Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.RightArrow)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.LeftArrow)))
        {
            sound_playerRotateSource.PlayOneShot(sound_playerRotate_Tail, 1.0f);
        }
    }
}
