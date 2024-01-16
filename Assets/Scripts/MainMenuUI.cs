using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Text playerNameText;

    public void ChangeName(string playerName)
    {
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

