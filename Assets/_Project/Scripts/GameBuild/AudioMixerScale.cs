using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerScale : MonoBehaviour
{ 
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _sliderVolumeMusic;
    [SerializeField] private Slider _sliderVolumeSound;
     
    public float _volumeMusic;
    public float _volumeSound;

    private void Start()
    {
        Load();
    }

    public void BTN_SliderMusic()
    {
        _volumeMusic = _sliderVolumeMusic.value;
        _audioMixer.SetFloat("Music", Mathf.Log10(_volumeMusic) * 20);
        PlayerPrefs.SetFloat("Music", _volumeMusic);
    }

    public void BTN_SliderSound()
    {
        _volumeSound = _sliderVolumeSound.value;
        _audioMixer.SetFloat("Sound", Mathf.Log10(_volumeSound) * 20);
        PlayerPrefs.SetFloat("Sound", _volumeSound);
    }
      
    public void Load()
    {
        _sliderVolumeSound.value = PlayerPrefs.GetFloat("Sound");
        _sliderVolumeMusic.value = PlayerPrefs.GetFloat("Music");

        BTN_SliderMusic();
        BTN_SliderSound();
    }
}