using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float xRotateSpeed = 15f;
    [SerializeField] private float yRotateSpeed = 15f;
    [SerializeField] private float zRotateSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime, zRotateSpeed * Time.deltaTime));        
    }
}
