using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public GameObject gm;
    private ScoreManager scoreManager;

    [SerializeField] private string nextLevel = "Boss Fight 1";
    [SerializeField] private const int MAX_COINS = 7;

    void Start()
    {
        scoreManager = gm.GetComponent<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (scoreManager.score == MAX_COINS)
            SceneManager.LoadScene(nextLevel);
    }
}
