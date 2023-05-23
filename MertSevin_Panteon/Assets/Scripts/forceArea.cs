using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceArea : MonoBehaviour
{
    public float forceMagnitude;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody otherRb = other.GetComponent<Rigidbody>();

        if (otherRb != null)
        {
            Vector3 force = Vector3.forward * forceMagnitude;
            otherRb.AddForce(force, ForceMode.Force);

        }
    }
}