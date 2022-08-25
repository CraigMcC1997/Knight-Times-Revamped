using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetPlayerPos : MonoBehaviour
{
    Vector3 originalPos;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
        originalPos = Player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DeathBox")
        {
            Player.transform.position = originalPos;
        }
    }
}
