using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] float sensitivity;
    float headRotation = 0f;
    [SerializeField] float headRotationLimit = 90f;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    { 
        
            float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1f;
            transform.Rotate(0f, x, 0f);
            headRotation += y;
            headRotation = Mathf.Clamp(headRotation, -headRotationLimit, headRotationLimit);
            cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Launch();
        }
        RayCast();
    }

    void RayCast()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        Ray ray = new Ray(origin, direction);

        if(Physics.Raycast(ray, out RaycastHit raycast))
        {
            raycast.collider.GetComponent<PlayerControlTorch>().target.GetComponent<Transform>().rotation = Camera.main.transform.rotation; 
        }
    }
    void Launch()
    {
        GameObject projectile = Instantiate(projectilePrefab) as GameObject;
        projectile.transform.position = transform.position + Camera.main.transform.forward;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * 20;
    }
}
