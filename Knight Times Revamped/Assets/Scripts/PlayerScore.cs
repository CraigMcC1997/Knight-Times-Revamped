using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private int currentScore = 0;

    public void updateScore()
    {
        currentScore++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "coin")
        {
            updateScore();
            Destroy(collision.gameObject);
        }
    }
}
