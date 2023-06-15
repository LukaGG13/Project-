using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float rotateSpeed = 90;
    public float speed = 8.9f;

    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.I))
        {
            controller.Move(move * speed);
            //controller.Move(move * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.K))
        {
            controller.Move(move * speed);
            //controller.Move(move * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, -rotateAmount, 0);
            //controller.Move(move * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, rotateAmount, 0);
            //controller.Move(move * speed * Time.deltaTime);
        }
    }
}
