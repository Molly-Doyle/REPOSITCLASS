using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameOverManager : MonoBehaviour
{

    public GameObject gameOverPanel;

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
