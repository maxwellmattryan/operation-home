using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float lifePoints = 5;
    public Transform healthBar;

    public GameObject camera;

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
            healthBar.gameObject.transform.localScale += new Vector3(-8, 0, 0);
            camera.GetComponent<ShakeBehavior>().TriggerShake();
        }
    }

}
