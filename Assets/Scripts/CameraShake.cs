using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    //public float spawnTimer;
    public Transform Camera;
    public float shakeAmount;
    Vector2 originalPos;
    public float shakeDuration;
    public float decreaseFactor;

    void Start()
    {
        originalPos = Camera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void Shake()
    {

        Camera.localPosition = originalPos + Random.insideUnitCircle * shakeAmount;
       // shakeDuration -= Time.deltaTime * decreaseFactor;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            InvokeRepeating("Shake", 2, 0);
           Shake();
        
        }

    }
}

