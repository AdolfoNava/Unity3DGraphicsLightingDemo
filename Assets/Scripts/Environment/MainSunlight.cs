using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSunlight : MonoBehaviour
{   public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    public Light mainLight;
    // Start is called before the first frame update

    void Start()
    {
        mainLight = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;
        //Change this line below
        transform.Rotate(new Vector3 (time, 0, 0));
        //Incorporate interpolation later
        if (changeColors)
        {
        float colorTime = (Mathf.Sin(Time.time - Time.time * colorSpeed));
        mainLight.color = Color.Lerp(startColor, endColor, colorTime);
        }

        //Ends the light source permamently 
        if (transform.rotation.x <0)
        {
            Destroy(mainLight);
        }
    }
}
