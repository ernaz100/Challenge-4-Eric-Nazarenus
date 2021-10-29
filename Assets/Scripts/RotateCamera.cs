using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, -hInput * rotationSpeed * Time.deltaTime);
    }
}
