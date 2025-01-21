using UnityEngine;
using Zenject;

public class SliderAndToggle : MonoBehaviour
{
     public MusicManager _musicManager;

    [Inject]
    public void Construct(MusicManager MusicManager)
    {
        _musicManager = MusicManager;
    } 

    public void BTM_Slider()
    {
        _musicManager.BTM_SliderMusic();
    }

    public void BTM_Toggle()
    {
        _musicManager.BTM_ToggleMusic();
    }
}
