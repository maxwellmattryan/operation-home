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


        Instantiate(Enemy);
        //Instantiate(Enemy, Random.insideUnitCircle * 5, earth.transform.rotation);

        Instantiate(Enemy,transform.position,Quaternion.identity);

    }

    void SetCoordinates()
    {
        Enemy.transform.RotateAround(Vector3.zero, Vector3.back, Random.Range(0, 360));
        Enemy.transform.LookAt(Vector3.zero);
    }
}
