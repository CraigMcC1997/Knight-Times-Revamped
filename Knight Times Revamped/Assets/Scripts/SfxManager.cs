using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip coinCollected;

    public static SfxManager SfxInstance;

    private void Awake()
    {
        if (SfxInstance != null && SfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        SfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
