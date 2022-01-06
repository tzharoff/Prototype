using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLauncher : MonoBehaviour
{
    [SerializeField] private GameObject cannonBall;
    [SerializeField] private GameObject shootPoint;
    [SerializeField] private float shotRate = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootCannonBall", 0f, shotRate);
    }

    private void ShootCannonBall()
    {
        Instantiate(cannonBall,shootPoint.transform.position,shootPoint.transform.rotation);
    }
}
