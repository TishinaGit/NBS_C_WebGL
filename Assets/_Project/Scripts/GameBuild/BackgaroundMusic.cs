using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BackgaroundMusic : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audioClips;  
    [SerializeField] private AudioSource _audioSource; 

    public void Awake()
    { 
        _audioSource = GetComponent<AudioSource>(); 
        StartCoroutine(PlayMusic());
    } 

    void Start()
    {  
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
}  