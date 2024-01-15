using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueChild : ParentClass
{
    private readonly float newRotateSpeed = 300.0f;

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
        GreetText.color = Color.blue;
        GreetText.text = "Hello " + SaveInfo.Instance.currentPlayer + ", My name is Sapphire.\nI can backflip!";
    }

    public override void RotateObject()
    {
        transform.Rotate(Vector3.right * newRotateSpeed * Time.deltaTime);
    }
}
