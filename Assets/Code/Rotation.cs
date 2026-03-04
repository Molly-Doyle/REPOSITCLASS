using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
    }
}
