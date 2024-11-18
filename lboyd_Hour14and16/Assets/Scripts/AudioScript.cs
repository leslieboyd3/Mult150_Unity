
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip backgroundMusic;
    AudioSource audioSource;

    public void BackgroundMusicEnabled()
    {
        audioSource.clip = backgroundMusic;
        audioSource.Play();
    }
    public void BackgroundMusicDisabled()
    {
        audioSource.clip = backgroundMusic;
        audioSource.Stop();
    }

// Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        //audioSource.loop = true; // lopping music in on
    }
}
