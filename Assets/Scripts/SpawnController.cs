using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnTimer;
    public GameObject earth;
    

    void Start()
    {
        InvokeRepeating("Spawn", spawnTimer, spawnTimer);
    }

    
    void Spawn()
    {
        SetCoordinates();
<<<<<<< HEAD

        Instantiate(Enemy);
        //Instantiate(Enemy, Random.insideUnitCircle * 5, earth.transform.rotation);
=======
<<<<<<< HEAD

        Instantiate(Enemy);
        //Instantiate(Enemy, Random.insideUnitCircle * 5, earth.transform.rotation);
=======
        Instantiate(Enemy,transform.position,Quaternion.identity);
>>>>>>> 343ba65381ed70057ab06aea40c0fa05f501853d
>>>>>>> parent of d62832b... add
    }

    void SetCoordinates()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, Random.Range(0, 360));
        transform.LookAt(Vector3.zero);
    }
}
