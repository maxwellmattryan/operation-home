using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBehavior : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
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
