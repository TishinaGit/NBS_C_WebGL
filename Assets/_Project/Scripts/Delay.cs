using UnityEngine;
using UnityEngine.UI;

public class Delay : MonoBehaviour
{
    public GameObject SceneInstaller;
    public GameObject LoadingCanvas; 
    public GameObject CameraSystem;
    public GameObject LabCanvas;
    public GameObject SettingsCanvas;
    public float r = 0;

    [SerializeField] private Image _sprite;
    void Update()
    {
        _sprite.fillAmount = r;

        if (r < 1)
        {
            r += Time.deltaTime;
        }
        else 
        {
            if (SceneInstaller != null) 
            {
                SceneInstaller.SetActive(true);
                
            }  
            if (CameraSystem != null)
            {
                CameraSystem.SetActive(true);
            }
            if (LabCanvas != null)
            {
                LabCanvas.SetActive(true);
            }
            if (SettingsCanvas != null)
            {
                SettingsCanvas.SetActive(true);
            }
            Destroy(LoadingCanvas);
        } 
    }
}
