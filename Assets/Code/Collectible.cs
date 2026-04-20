using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f;
    [Header("Pickup Effect")]
    [SerializeField] private ParticleSystem pickupEffectPrefab; // assign in inspector

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    private int trashCounter = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {


            // Spawn pickup particle effect
            if (pickupEffectPrefab != null)
            {
                ParticleSystem effect = Instantiate(pickupEffectPrefab, transform.position, Quaternion.identity);
                effect.Play();

                // Optional: destroy the particle system after it finishes
                Destroy(effect.gameObject, effect.main.duration + effect.main.startLifetime.constantMax);
            }

            // Destroy the collectible
            Destroy(gameObject);

            //Add to the counter
            trashCounter +=1;
        }
    }
}