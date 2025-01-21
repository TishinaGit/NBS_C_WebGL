using UnityEngine;
using UnityEngine.UI; 
using Zenject;

public class MainMenuInstaller : MonoInstaller
{  
    public Toggle Toggle;
    public Slider Slider;
    public MusicManager MusicManager;
    public override void InstallBindings()
    {  
        ToggleObject();
        SliderObject();
        MusicManagerObject();
    } 
    
    public void ToggleObject()
    {
        Container.Bind<Toggle>().FromInstance(Toggle).AsSingle();
    }
    public void SliderObject()
    {
        Container.Bind<Slider>().FromInstance(Slider).AsSingle();
    }
    public void MusicManagerObject()
    {
        Container.Bind<MusicManager>().FromInstance(MusicManager).AsSingle();
    }
}
