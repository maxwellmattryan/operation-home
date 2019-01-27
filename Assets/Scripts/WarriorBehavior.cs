using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBehavior : MonoBehaviour
{
    public float speed;
    // public float movementSpeed;
    public GameObject earth;

    // Start is called before the first frame update
    void Start()
    {
        //Quaternion lookRotation = (z.transform.position - transform.position).normalized;
        //Vector3 


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       // transform.LookAt(earth.transform);
       // transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            //increment score
        }
        else if (other.gameObject.CompareTag("Earth"))
        {
            Destroy(this.gameObject);
            //damage earth
        }
    }
}
