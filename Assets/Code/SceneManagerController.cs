using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SceneManagerController : MonoBehaviour
{   

    public void OnStartClick()
    {
        SceneManager.LoadScene("LevelOne");
    }

    

    public void OnMenuClick()
    {
        SceneManager.LoadScene("MENU");
    }

    public void OnRestartClick()
    {
        SceneManager.LoadScene("MENU");
    }

public void OnExitClick()
    {

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();
    }
}