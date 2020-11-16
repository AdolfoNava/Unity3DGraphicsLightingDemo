using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public GameObject torch;
    public static bool disabled = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (disabled)
            torch.SetActive(false);
        else
            torch.SetActive(true);
    }

}
