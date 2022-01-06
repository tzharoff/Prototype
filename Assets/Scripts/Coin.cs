using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    public static Action CoinCollect;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin Collected");
        if(CoinCollect != null)
        {
            CoinCollect();
        }

        Destroy(gameObject);
    }
}
