using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 5.0f;
    private float screenBoundaryX = 10.0f;
    private float screenBoundaryZTop = 11.0f;
    private float screenBoundaryZBottom = -1.5f;

    void Update()
    {
        UserMovement();    //Abstraction
        CheckScreenBoundary();    //Abstraction
    }

    private void UserMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    private void CheckScreenBoundary()
    {
        if (transform.position.x < -screenBoundaryX)
        {
            transform.position = new Vector3(-screenBoundaryX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > screenBoundaryX)
        {
            transform.position = new Vector3(screenBoundaryX, transform.position.y, transform.position.z);
        }

        if (transform.position.z < screenBoundaryZBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, screenBoundaryZBottom);
        }
        else if (transform.position.z > screenBoundaryZTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, screenBoundaryZTop);
        }
    }
}
