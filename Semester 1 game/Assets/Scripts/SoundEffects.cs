using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffects : MonoBehaviour
{
    private float soundEffectVolume = 1f;
    public Slider sliderVolumeEffects;
    public AudioSource[] soundEffectAudioSource;
    // Start is called before the first frame update
    //public GameObject musicObject;
  
    // Start is called before the first frame update
    void Start()
    {
       


        soundEffectVolume = PlayerPrefs.GetFloat("volumeEffect");
       
        
        foreach (AudioSource audio in soundEffectAudioSource)
        {
            //soundEffectVolume = PlayerPrefs.GetFloat("volumeEffect");
            audio.volume = soundEffectVolume;
            sliderVolumeEffects.value = soundEffectVolume;

        }
    }


    // Update is called once per frame
    void Update()
    {
       
        foreach (AudioSource audio in soundEffectAudioSource)
        {
            audio.volume = soundEffectVolume;
            PlayerPrefs.SetFloat("volumeEffect", soundEffectVolume);

        }

    }

    public void VolumeUpdate(float volume)
    {
        soundEffectVolume = volume;
    }
    



    /*[SerializeField] AudioSource[] SFXSource;
    //[SerializeField] AudioSource SFXSource2;
    [SerializeField] Slider SFXvolumeSlider;

    public void Start()
    {
        foreach (AudioSource SFX in SFXSource)
        {
            SFX.volume = PlayerPrefs.GetFloat("sfxVol");
            SFXvolumeSlider.value = SFX.volume;
        }
    }
    */


}
