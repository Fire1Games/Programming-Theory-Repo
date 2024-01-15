using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ParentClass : MonoBehaviour
{
    public static Text MainText { get; private set; }
    public static Text GreetText { get; private set; }

    private float rotateSpeed = 30.0f;

    public bool isColliding = false;


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
        MainText.gameObject.SetActive(false);
        GreetText.gameObject.SetActive(true);
        GreetText.color = Color.red;
        GreetText.text = "Hello, My name is Ruby. I can spin!";
    }

    public virtual void RotateObject()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}