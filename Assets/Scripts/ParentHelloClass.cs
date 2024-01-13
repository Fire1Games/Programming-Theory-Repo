using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ParentHelloClass : MonoBehaviour
{
    public static Text MainText { get; private set; }
    public static Text GreetText { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        MainText = GameObject.Find("Main TextBox").GetComponent<Text>();
        GreetText = GameObject.Find("Child TextBox").GetComponent<Text>();

        MainHello();
    }

    private void MainHello()
    {
        MainText.gameObject.SetActive(true);
        MainText.text = "Greetings, we are the Magnificent 3!";
    }

    public virtual void Greet()
    {
        GreetText.gameObject.SetActive(true);
        GreetText.text = "Hello, My name is Red";
    }
}
