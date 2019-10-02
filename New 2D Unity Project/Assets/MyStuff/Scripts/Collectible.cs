using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Collectible : MonoBehaviour
{
    private bool _hasBeencollected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_hasBeencollected && collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            HandleCollected();
        }
    

        if (!_hasBeencollected)
        {
            HandleCollected();
        }
    }

    void HandleCollected()
    {
        _hasBeencollected = true;
        Destroy(gameObject);
        CollectibleManager.Instance.HandleCoinCollected();
    }
}