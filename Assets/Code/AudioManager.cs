using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header ("Audio Clip")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip hit;
    public AudioClip itemPickup;
    public AudioClip UIClick;
    public AudioClip saveGame;
    public AudioClip openInventory;
}