using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    [SerializeField] private string nextLevel = "Boss Fight 1";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
