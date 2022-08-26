using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject gm;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = gm.GetComponent<ScoreManager>();
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
