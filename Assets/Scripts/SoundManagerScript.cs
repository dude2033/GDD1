using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManagerScript : MonoBehaviour
{

    public AudioClip Bunker;
    public AudioClip Past;
    public AudioClip FutureGood;
    public AudioClip FutureBad;

    public Slider VolumeSlider;

    public void ChangeSound(string sound)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if(sound == "Bunker")
        {
            audio.clip = Bunker;
        }
        else if(sound == "Past")
        {
            audio.clip = Past;
        }
        else if (sound == "FutureBad")
        {
            audio.clip = FutureBad;
        }
        else if (sound == "FutureGood")
        {
            audio.clip = FutureGood;
        }
        audio.Play();
    }

    void OnEnable()
    {
        VolumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(VolumeSlider.value); });
    }

    public void ChangeVolume(float volume)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.volume = volume;
    }

}
