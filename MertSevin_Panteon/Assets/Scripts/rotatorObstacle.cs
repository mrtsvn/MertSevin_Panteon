using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatorObstacle : MonoBehaviour
{
    public float rotatorSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotatorSpeed * Time.deltaTime);
    }
}
