using UnityEngine.SceneManagement;

public class GameUI : MainMenuUI
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
