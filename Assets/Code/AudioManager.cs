using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get; private set;}

<<<<<<< HEAD
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
=======
    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;

    //ADD SFX

    void Awake()
    {
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }
    }

    private void Start()

    {
    if(backgroundMusic != null && musicSource != null)
    {
        musicSource.clip =backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    } 
>>>>>>> parent of fb817d3 (Item pickup into inventory added)
    }

    public void PlaySFX(AudioClip clip)
    {
<<<<<<< HEAD
        SFXSource.PlayOneShot(clip);
    }
}
=======
        if(clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip);
            //Playoneshot plays a clip once
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (clip != null && musicSource != null)
        {
            musicSource.clip = clip;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}
>>>>>>> parent of fb817d3 (Item pickup into inventory added)
