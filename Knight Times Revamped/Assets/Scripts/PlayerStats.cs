using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject gameUI;
    private ScoreManager scoreManager;
    private HealthManager healthManager;

    private void Start()
    {
        scoreManager = gameUI.GetComponent<ScoreManager>();
        healthManager = gameUI.GetComponent<HealthManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //increase score when coin is collected
        if (collision.gameObject.name == "coin")
        {
            scoreManager.increaseScore();
            Destroy(collision.gameObject);
        }

        //have player take damage when colliding with enemy
        if (collision.gameObject.name == "Light" ||
            collision.gameObject.name == "Ranged" ||
            collision.gameObject.name == "Heavy")
        {
            healthManager.takeDamage();
        }
    }
}
