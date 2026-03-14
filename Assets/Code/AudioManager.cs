using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get; private set;}

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header ("Audio Clip")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip hit;
    public AudioClip chasePlayer;
    public AudioClip itemPickup;
    public AudioClip UIClick;
    public AudioClip saveGame;
    public AudioClip openInventory;
    public AudioClip limbo;
    public AudioClip cutscene;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}