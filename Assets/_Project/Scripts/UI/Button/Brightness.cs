using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    [SerializeField] private Image _sprite;
    [SerializeField] private Slider _sliderVolumeMusic;
    private float BrightnessScale;

    private void Awake()
    {
        Load();
    }

    public void BTM_BrightnessSlider()
    {
        if (_sliderVolumeMusic != null)
        {
            BrightnessScale = _sliderVolumeMusic.value;
            PlayerPrefs.SetFloat("volume", BrightnessScale);
            BrightnessImage();
        }
    }

    private void BrightnessImage()
    {
        var color = _sprite.color;
        color.a = BrightnessScale;
        _sprite.color = color;
    }
     
    private void Load()
    {
        _sliderVolumeMusic.value = PlayerPrefs.GetFloat("volume");
        BTM_BrightnessSlider();
    }
}
