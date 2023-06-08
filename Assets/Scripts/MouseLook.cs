using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation = 0f;
    float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxisRaw("Mouse X") * sensX * Time.deltaTime;
        float MouseY = Input.GetAxisRaw("Mouse Y") * sensY * Time.deltaTime;

        yRotation += MouseX;

        xRotation -= MouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        orientation.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}