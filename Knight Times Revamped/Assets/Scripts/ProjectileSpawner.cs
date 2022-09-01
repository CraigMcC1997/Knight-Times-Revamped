using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public void TriggerSpawn()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
