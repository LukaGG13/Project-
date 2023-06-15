using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Transform player;
    public Transform firstPersonCamera;
    public Transform thirdPersonCamera;
    private bool isFirstPerson = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFirstPerson = !isFirstPerson;
            SwitchCamera();
        }

    }

    private void SwitchCamera()
    {
        if (isFirstPerson)
        {
            // Enable first-person camera and disable third-person camera
            firstPersonCamera.gameObject.SetActive(true);
            thirdPersonCamera.gameObject.SetActive(false);
        }

        else
        {
            // Enable third-person camera and disable first-person camera
            firstPersonCamera.gameObject.SetActive(false);
            thirdPersonCamera.gameObject.SetActive(true);

            // Adjust the camera's position relative to the player
            Vector3 offset = new Vector3(0f, 2f, -5f);
            thirdPersonCamera.position = player.position + offset;
            thirdPersonCamera.LookAt(player);
        }
    }
}