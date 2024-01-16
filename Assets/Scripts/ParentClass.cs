using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ParentClass : MonoBehaviour
{
    public static Text MainText { get; private set; }    //Encapsulation
    public static Text GreetText { get; private set; }    //Encapsulation
    public static float RotateSpeed { get; private set; }    //Encapsulation

    public bool isColliding = false;


    void Start()
    {
        MainText = GameObject.Find("Main TextBox").GetComponent<Text>();
        GreetText = GameObject.Find("Child TextBox").GetComponent<Text>();

        RotateSpeed = 250.0f;

        MainHello();    //Abstraction
    }


    private void MainHello()
    {
        MainText.gameObject.SetActive(true);
        MainText.text = "Greetings, we are the Magnificent 3!";
    }


    public virtual void Greet()    //Polymorphism
    {
        MainText.gameObject.SetActive(false);
        GreetText.gameObject.SetActive(true);
        GreetText.color = Color.red;
        GreetText.text = "Hello " + SaveInfo.Instance.currentPlayer + ", My name is Ruby.\nI can spin!";
    }

    public virtual void RotateObject()    //Polymorphism
    {
        transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
    }
}