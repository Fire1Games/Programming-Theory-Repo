using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedChild : ParentClass
{
    private void Update()
    {
        if (isColliding)
        {
            RotateObject();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            isColliding = true;
            Greet();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            isColliding = false;
            MainText.gameObject.SetActive(true);
            GreetText.gameObject.SetActive(false);
        }
    }
}
