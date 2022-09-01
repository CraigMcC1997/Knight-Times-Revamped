using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SfxManager.SfxInstance.Audio.PlayOneShot(SfxManager.SfxInstance.coinCollected);
        Destroy(this.gameObject);
    }
}
