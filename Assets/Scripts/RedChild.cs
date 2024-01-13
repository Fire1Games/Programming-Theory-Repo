using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedChild : ParentHelloClass
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
}
