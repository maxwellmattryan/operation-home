using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float lifePoints = 5;
    public Transform healthBar;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lifePoints == 0)
        {
            SceneManager.LoadScene("GameOverScene");

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            lifePoints -= 1;
            healthBar.gameObject.transform.localScale += new Vector3(-1, 0, 0);

        }

    }

}
