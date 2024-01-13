using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedChildHelloClass : ParentHelloClass
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            MainText.gameObject.SetActive(false);
            Greet();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            GreetText.gameObject.SetActive(false);
            MainText.gameObject.SetActive(true);
        }
    }
}
