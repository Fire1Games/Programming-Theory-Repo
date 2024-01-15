using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text playerNameText;

    public void ChangeName(string playerName)
    {
        //method to carry player name between scenes
        playerNameText.text = playerName;
        SaveInfo.Instance.currentPlayer = playerName;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


    public void QuitAppButton()
    {
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        }
    }
}

