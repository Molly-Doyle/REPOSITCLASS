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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trashText.text = "Trashbags Collected:" + trashCount.ToString();

        if(trashCount == 16)
        {
           
        }
    }
}
