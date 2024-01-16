using UnityEngine.SceneManagement;

public class GameUI : MainMenuUI    //Inheritance
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
