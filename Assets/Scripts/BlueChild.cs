using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueChild : ParentHelloClass
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            Greet();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            MainText.gameObject.SetActive(true);
            GreetText.gameObject.SetActive(false);
        }
    }

    public override void Greet()
    {
        MainText.gameObject.SetActive(false);
        GreetText.gameObject.SetActive(true);
        GreetText.color = Color.blue;
        GreetText.text = "Hello, My name is Blue";
    }
}
