using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LightGenerationScript : MonoBehaviour
{

    public GameObject lightSource;
    public GameObject newCreation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DestroyPrefab();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            CreatePrefab();
        }
        
    }
    public void CreatePrefab()
    {
        float instX = 6;
        float instY = 2;
        float instZ = 4;
        newCreation = Instantiate(lightSource, new Vector3(instX, instY, instZ), Quaternion.identity);
    }
    public void DestroyPrefab()
    {
        Destroy(newCreation);
    }
}
