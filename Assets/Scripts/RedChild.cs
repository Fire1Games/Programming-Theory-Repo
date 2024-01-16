using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedChild : ParentClass    //Inheritance
{
    private void Update()
    {
        if (isColliding)
        {
            RotateObject();    //Abstraction
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            isColliding = true;
            Greet();    //Abstraction
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
