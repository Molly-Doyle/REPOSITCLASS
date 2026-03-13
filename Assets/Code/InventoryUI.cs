using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    AudioManager audioManager;

    public GameObject menuCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
            audioManager.PlaySFX(audioManager.openInventory);
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}