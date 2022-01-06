using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hazard : MonoBehaviour
{

    public static Action HitHazard;
    [SerializeField] private bool destroyOnContact = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerPosition>().Reset();
            if(HitHazard != null)
            {
                HitHazard();
            }
        }
        if(destroyOnContact == true)
        {
            Destroy(gameObject);
        }
    }
}
