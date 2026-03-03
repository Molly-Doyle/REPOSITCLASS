using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu : MonoBehaviour
{   
    
    public CanvasGroup startMenu;
    public CanvasGroup optionsMenu;

    public void play()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        ShowOptionsMenuInstant();
    }

    public void BackToStartMenu()
    {
        ShowStartMenuInstant();
    }
}
