using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSunlight : MonoBehaviour
{   public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public float turnSpeed = 2f;
    public Color startColor;
    public Color endColor;
    public float sunTime = 18;

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
        transform.Rotate(Vector3.right, turnSpeed*time);
        //Incorporate interpolation later
        if (changeColors)
        {
        float colorTime = (Mathf.Sin(Time.time - Time.time * colorSpeed));
        mainLight.color = Color.Lerp(startColor, endColor, colorTime);
        }

        //Ends the light source permamently 
        if (Time.time >sunTime)
        {
            Destroy(mainLight);
        }
    }
}
