using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGun : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
    }
}
