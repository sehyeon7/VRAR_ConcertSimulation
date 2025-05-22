using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip danceClip;
    public AudioClip acousticClip;
    public AudioClip classicClip;

    public void PlayMusic(string musicType)
    {
        switch (musicType)
        {
            case "Dance":
                Debug.Log("▶️ Playing Dance music");
                audioSource.clip = danceClip;
                break;
            case "Acoustic":
                Debug.Log("🎵 Playing Acoustic music");
                audioSource.clip = acousticClip;
                break;
            case "Classic":
                Debug.Log("🎶 Playing Classic music");
                audioSource.clip = classicClip;
                break;
            default:
                Debug.LogWarning("Unknown music type: " + musicType);
                return;
        }
        Debug.Log($"Playing clip: {audioSource.clip.name}");
        audioSource.Play();
    }

    public void PlayDanceIfOn(bool isOn)
    {
        if (isOn) PlayMusic("Dance");
    }
    public void PlayAcousticIfOn(bool isOn)
    {
        if (isOn) PlayMusic("Acoustic");
    }
    public void PlayClassicIfOn(bool isOn)
    {
        if (isOn) PlayMusic("Classic");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
