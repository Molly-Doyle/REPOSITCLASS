using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FactorySceneChanger : MonoBehaviour
{

    public string sceneToLoad;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
                SceneManager.LoadScene("Ending");
        }
    }


}