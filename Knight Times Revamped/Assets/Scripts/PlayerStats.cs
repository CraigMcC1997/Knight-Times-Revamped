using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int lives = 3;

    public GameObject gm;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = gm.GetComponent<ScoreManager>();
    }

    //currently unused
    public void lowerHealth()
    {
        health--;
    }

    //currently unused
    public void removeLife()
    {
        lives--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "coin")
        {
            scoreManager.increaseScore();
            Destroy(collision.gameObject);
        }
    }
}
