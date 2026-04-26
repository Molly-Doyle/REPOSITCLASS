using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public int trashCount;
    public TMP_Text trashText;
    public GameObject factorySceneChanger;

    void Update()
    {
        trashText.text = "Collected Trash: " + trashCount.ToString();

        if(trashCount == 16)
        {
            Destroy(factorySceneChanger);
        }
    }
}