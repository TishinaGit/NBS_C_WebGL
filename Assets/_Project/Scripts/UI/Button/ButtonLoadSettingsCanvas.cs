using UnityEngine; 

public class ButtonLoadSettingsCanvas : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvas;
    [SerializeField] private GameObject _settingsCanvas;
     
    public void BTM_OpenSettings()
    {
        _settingsCanvas.SetActive(true);
        _mainMenuCanvas.SetActive(false);
    }

    public void BTM_CloseSettings()
    {
        _settingsCanvas.SetActive(false);
        _mainMenuCanvas.SetActive(true);
    }
}
