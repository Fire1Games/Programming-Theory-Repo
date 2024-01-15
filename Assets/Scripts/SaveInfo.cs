using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    public static SaveInfo Instance;
    public string currentPlayer;

    private void Awake()
    {
        //Create instance on awake, destroys any extra instances, doesn't destroy instance between scenes
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
