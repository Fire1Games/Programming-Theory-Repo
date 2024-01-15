using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenChild : ParentClass
{
    private float newRotateSpeed = 90.0f;

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
    public override void Greet()
    {
        MainText.gameObject.SetActive(false);
        GreetText.gameObject.SetActive(true);
        GreetText.color = Color.green;
        GreetText.text = "Hello, My name is Emerald. I can cartwheel!";
    }

    public override void RotateObject()
    {
        transform.Rotate(Vector3.forward * newRotateSpeed * Time.deltaTime);
    }
}
