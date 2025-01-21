using UnityEngine;
using Zenject;

public class EventDeathPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _canvasDeathPlayer;
    [SerializeField] private GameObject _cameraCanvas;
    [SerializeField] private GameObject _canvasTask;
    [SerializeField] private EntitySpawner _entitySpawner;
 
    public void DeathPlayerEvent()
    { 
        _entitySpawner.enabled = false;
        _canvasDeathPlayer.SetActive(true);
        _cameraCanvas.SetActive(true);
        _canvasTask.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
