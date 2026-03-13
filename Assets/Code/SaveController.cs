using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class SaveController : MonoBehaviour
{
    private string saveLocation;
    private InventoryController inventoryController;
    AudioManager audioManager;

    void Start()
    {
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        inventoryController = FindFirstObjectByType<InventoryController>();

        LoadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData
        {
            playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position,
            inventorySaveData = inventoryController.GetInventoryItems()
        };

        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.PlaySFX(audioManager.saveGame);
    }

    public void LoadGame()
        {
        if(File.Exists(saveLocation))
        {
            SaveData saveData =JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));
            GameObject.FindGameObjectWithTag("Player").transform.position = saveData.playerPosition;

            inventoryController.SetInventoryItems(saveData.inventorySaveData);
        }
        else
        {
            SaveGame();
        }
    }
}
