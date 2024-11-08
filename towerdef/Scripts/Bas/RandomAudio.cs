using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomAudio : MonoBehaviour
{

    // Playing another song once the one that played has finished

    public AudioClip[] soundtrack;
    public bool PlayMusic = true;

    void Update()
    {

        if (PlayMusic == true)
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                GetComponent<AudioSource>().clip = soundtrack[Random.Range(0, 12)];
                GetComponent<AudioSource>().Play();
            }
        }
    }

    // Here will be all the buttons to play individual songs according to their order in the Array

    public void CurboSong()
    {
        GetComponent<AudioSource>().clip = soundtrack[12];
        GetComponent<AudioSource>().Play();
    }

    public void RandomSong()
    {
        GetComponent<AudioSource>().clip = soundtrack[Random.Range(0, 12)];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing the next song");
    }

    public void Song01 ()
    {
        GetComponent<AudioSource>().clip = soundtrack[0];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Legacy (Dirty Palm & Benix)");
    }
    
    public void Song02 ()
    {
        GetComponent<AudioSource>().clip = soundtrack[1];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Like you (MILANE & Greg Aven");
    }

    public void Song03 ()
    {
        GetComponent<AudioSource>().clip = soundtrack[2];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Odyssey (Kato, Spyker & TOBSIK)");
    }

    public void Song04 ()
    {
        GetComponent<AudioSource>().clip = soundtrack[3];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Time (OVSKY)");
    }
    
    public void Song05 ()
    {
        GetComponent<AudioSource>().clip = soundtrack[4];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Trust me (DigEx)");
    }

    public void Song06()
    {
        GetComponent<AudioSource>().clip = soundtrack[5];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Cat Cafe (Kosu & Marco)");
    }

    public void Song07()
    {
        GetComponent<AudioSource>().clip = soundtrack[6];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Daft (Kosu)");
    }

    public void Song08()
    {
        GetComponent<AudioSource>().clip = soundtrack[7];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Daze (Kosu)");
    }

    public void Song09()
    {
        GetComponent<AudioSource>().clip = soundtrack[8];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Tell me (Kosu)");
    }

    public void Song10()
    {
        GetComponent<AudioSource>().clip = soundtrack[9];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Thirds VIP (Kosu)");
    }

    public void Song11()
    {
        GetComponent<AudioSource>().clip = soundtrack[10];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Mania (Lucid Monday & Kosu)");
    }

    public void Song12()
    {
        GetComponent<AudioSource>().clip = soundtrack[11];
        GetComponent<AudioSource>().Play();
        Debug.Log("Now playing: Gourmet Race X Doom (Geoffrey Day)");
    }

    // Knoppen om muziek te pauzeren / af te spelen

    public void SongPlay()
    {
        GetComponent<AudioSource>().Play();
        PlayMusic = true;
    }

    public void SongPause()
    {
        GetComponent<AudioSource>().Pause();
        PlayMusic = false;
    }

    // to connect the slider, the volume & the number displayed together

    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private Text volumeTextUI = null;

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.00");
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
