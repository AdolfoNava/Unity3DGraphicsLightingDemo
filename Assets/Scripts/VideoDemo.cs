using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoDemo : MonoBehaviour
{
    public Transform target;

    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
    }
}
