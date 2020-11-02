using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalLightObject : MonoBehaviour
{

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector3 direction)
    {
        rigidbody.AddForce(direction * 300);
    }
}
