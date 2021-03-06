﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBehavior : MonoBehaviour
{
    public float speed;
    // public float movementSpeed;
    public GameObject earth;
    public Transform target;//set target from inspector instead of looking in Update

    AudioSource source_implosion;
    private AudioClip _clip_implosion;

    // Start is called before the first frame update
    void Start()
    {
        //Quaternion lookRotation = (z.transform.position - transform.position).normalized;
        //Vector3 

        source_implosion = GetComponent<AudioSource>();
        source_implosion.clip = _clip_implosion;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self); //correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            //move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Sound here");
            source_implosion.clip = _clip_implosion;
            source_implosion.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            //increment score
        }
        else if (other.gameObject.CompareTag("Earth"))
        {
            
            Destroy(this.gameObject,0.5f);
            //damage earth
        }
    }
}
