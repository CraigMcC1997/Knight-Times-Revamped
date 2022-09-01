using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempTriggerEvent : MonoBehaviour
{
    public ProjectileSpawner spawner;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            spawner.TriggerSpawn();
    }

}
