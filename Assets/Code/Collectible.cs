using System;
using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f; // degrees per second

    private int trashCounter = 0;
    public TMP_Text counterText;
    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           trashCounter ++;
           counterText.text = "Collected Trash: " + trashCounter;
        
            Destroy(gameObject);
        }
    }
}
