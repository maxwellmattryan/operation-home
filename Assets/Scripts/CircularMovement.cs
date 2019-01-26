using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public GameObject Earth;
    public float speed;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKey(KeyCode.D))|| (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.RotateAround(Earth.transform.position, Vector3.back, speed * Time.deltaTime);
        }
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.RotateAround(Earth.transform.position, Vector3.forward, speed * Time.deltaTime);
        }

    }
}
