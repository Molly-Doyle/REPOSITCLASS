using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerItemCollector : MonoBehaviour
{
    private InventoryController inventoryController;

    void Start()
    {
        inventoryController = FindFirstObjectByType<InventoryController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Item"))
        {
            Item item = collision.GetComponent<Item>();
            if(item != null)
            {
                //Add Item inventory
                bool itemAdded = inventoryController.AddItem(collision.gameObject);

                if(itemAdded)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}