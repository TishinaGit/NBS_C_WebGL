using Cinemachine;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(AudioSource))]
public class ActionsKeyE : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource; 
    [SerializeField] private CanvasOpenAndClose _canvasOpenAndClose;

    public GameObject _canvasActionEText;
    public int IndexGameObject;

    private CinemachineFreeLook _cinemachineFreeLook;

    [Inject]
    public void Construct(CinemachineFreeLook CinemachineFreeLook, Canvas CanvasActionEText)
    {
        _cinemachineFreeLook = CinemachineFreeLook;
        _canvasActionEText = CanvasActionEText.gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            _canvasActionEText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                _audioSource.Play();
                _cinemachineFreeLook.m_XAxis.m_MaxSpeed = 0f;
                _cinemachineFreeLook.m_YAxis.m_MaxSpeed = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;

                _canvasOpenAndClose.OpenCanvas(IndexGameObject);
            }
        }
    }
     
    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            _cinemachineFreeLook.m_XAxis.m_MaxSpeed = 250f;
            _cinemachineFreeLook.m_YAxis.m_MaxSpeed = 1f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            _canvasActionEText.SetActive(false);

            _canvasOpenAndClose.CloseCanvas(IndexGameObject);
        }
    } 
}
