using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMusic : MonoBehaviour
{
    private AudioSource audioMainMusic;
    public GameObject musicObject;
    private float musicVolume = 1f;
    public Slider sliderVolume;
    // Start is called before the first frame update
    void Start()
    {
        musicObject = GameObject.FindWithTag("GameMusic");
        audioMainMusic = musicObject.GetComponent<AudioSource>();
        
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioMainMusic.volume = musicVolume;
        sliderVolume.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        audioMainMusic.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void VolumeUpdate(float volume)
    {
        musicVolume = volume;
    }

    public void MusicVolumeReset()
    {
        PlayerPrefs.DeleteKey("volume");
        audioMainMusic.volume = 1;
        sliderVolume.value = 1;
    }
}
