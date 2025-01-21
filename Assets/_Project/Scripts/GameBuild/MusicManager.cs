using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

[RequireComponent(typeof(AudioSource))]
public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audioClips;  
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _volume;

    public Slider _sliderVolumeMusic;
    public Toggle _toggleMusic;

    [Inject]
    public void Construct(Toggle Toggle, Slider Slider)
    {
        _toggleMusic = Toggle;
        _sliderVolumeMusic = Slider; 
    }

    public void Awake()
    {
        DontDestroyOnLoad(this);
        _audioSource = GetComponent<AudioSource>();

        StartCoroutine(PlayMusic());
    } 

    void Start()
    { 
        Load();
        ValueMusic();
        StartCoroutine(Foo());
        StartCoroutine(Bar());
    }
    IEnumerator PlayMusic()
    {
        for (int i = 0; i < _audioClips.Length; i++)
        {
            _audioSource.PlayOneShot(_audioClips[i]);
            while (_audioSource.isPlaying)
                yield return null;
        }
    }

    IEnumerator Foo()
    {
        yield return null;
    }
    IEnumerator Bar()
    {
        yield return null;
    }
    public void BTM_SliderMusic()
    {
        if (_sliderVolumeMusic != null)
        {
            _volume = _sliderVolumeMusic.value;
            Save();
            ValueMusic();
        } 
    }

    public void BTM_ToggleMusic()
    {
        if ( _toggleMusic != null)
        {
            if (_toggleMusic.isOn == true)
            {
                _volume = 0.1f;
            }
            else
            {
                _volume = 0;
            }
            Save();
            ValueMusic();
        } 
    }

    private void ValueMusic()
    {
        if (_audioSource != null && _sliderVolumeMusic != null)
        {
            _audioSource.volume = _volume;
            _sliderVolumeMusic.value = _volume;
            if (_volume == 0) { _toggleMusic.isOn = false; } else { _toggleMusic.isOn = true; }
        } 
    }

    private void Save() => PlayerPrefs.SetFloat("volume", _volume); 
    private void Load() => _volume = PlayerPrefs.GetFloat("volume", _volume);
}
