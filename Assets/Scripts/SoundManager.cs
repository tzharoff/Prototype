using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource coinAudioSource;

    private void OnEnable()
    {
        Coin.CoinCollect += PlayCoinSound;
    }

    private void OnDisable()
    {
        Coin.CoinCollect -= PlayCoinSound;
    }


    private void PlayCoinSound()
    {
        coinAudioSource.Play();
    }


}
