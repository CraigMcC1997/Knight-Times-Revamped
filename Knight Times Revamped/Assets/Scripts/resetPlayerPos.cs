using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetPlayerPos : MonoBehaviour
{
    Vector3 originalPos;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        originalPos = player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DeathBox")
        {
            player.transform.position = originalPos;
        }
    }
}
