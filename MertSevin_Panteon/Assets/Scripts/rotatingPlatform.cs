using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingPlatform : MonoBehaviour
{
    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime); //rotating object

    }
}
