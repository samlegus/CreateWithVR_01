using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 2.5f;
   
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);   
    }
}
