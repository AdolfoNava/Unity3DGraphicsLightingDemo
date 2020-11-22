using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public GameObject torch;
    
    // Start is called before the first frame update
    void Start()
    {
        torch.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(true);
        torch.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        torch.SetActive(false);
    }
}
