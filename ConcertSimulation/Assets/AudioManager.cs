using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip danceClip;
    public AudioClip acousticClip;
    public AudioClip classicClip;

    public float volume = -1.0f;

    string type = "None";

    public void PlayMusic(string musicType)
    {
        switch (musicType)
        {
            case "Dance":
                audioSource.resource = danceClip;
                break;
            case "Acoustic":
                audioSource.resource = acousticClip;
                break;
            case "Classic":
                audioSource.resource = classicClip;
                break;
            default:
                Debug.LogWarning("Unknown music type: " + musicType);
                return;
        }
        Debug.Log($"Playing clip: {audioSource.resource.name}");
        audioSource.Play();
    }

    public void PlayDanceIfOn()
    {
        type = "Dance";
        PlayMusic("Dance");
    }
    public void PlayAcousticIfOn()
    {
        Debug.Log("🎵 Playing Acoustic music");
        PlayMusic("Acoustic");
    }
    public void PlayClassicIfOn()
    {
        Debug.Log("🎶 Playing Classic music");
        PlayMusic("Classic");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (volume >= 0.0f)
        {
            audioSource.volume = volume;
            volume = -1.0f;
        }
    }
}
