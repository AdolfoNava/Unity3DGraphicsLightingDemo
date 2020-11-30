using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlTorch : MonoBehaviour
{
    //Vector3 mPosChange = Vector3.zero;
    //Vector3 mBeforePos = Vector3.zero;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
        /*mPosChange = Input.mousePosition - mBeforePos;
        if (Input.GetMouseButton(0))
        {
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, Vector3.Dot(mPosChange, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, -Vector3.Dot(mPosChange, Camera.main.transform.right), Space.World);
            }
            transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosChange, Camera.main.transform.up), Space.World);
        }
        mBeforePos = Input.mousePosition;
        */
    }

}
