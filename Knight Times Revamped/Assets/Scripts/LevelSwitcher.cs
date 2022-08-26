using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public GameObject gameUI;
    private ScoreManager scoreManager;

    public string nextLevel = "Boss Fight 1";
    public const int MAX_COINS = 7;

    void Start()
    {
        scoreManager = gameUI.GetComponent<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (scoreManager.score == MAX_COINS)
            SceneManager.LoadScene(nextLevel);
    }
}
