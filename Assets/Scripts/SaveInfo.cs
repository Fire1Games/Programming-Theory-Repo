using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    public static SaveInfo Instance;
    public string currentPlayer;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
