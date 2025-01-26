using Cinemachine;
using UnityEngine;
using Zenject;

public class CloseCanvasButton : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;

    private CinemachineFreeLook _cinemachineFreeLook;

    [Inject]
    public void Construct(CinemachineFreeLook CinemachineFreeLook)
    {
        _cinemachineFreeLook = CinemachineFreeLook; 
    }

    public void BTN_CloseCanvas()
    {
        _cinemachineFreeLook.m_XAxis.m_MaxSpeed = 250f;
        _cinemachineFreeLook.m_YAxis.m_MaxSpeed = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;  
        _canvas.SetActive(false);
    }
}
