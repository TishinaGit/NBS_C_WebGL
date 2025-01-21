using Controller;
using System.Collections;
using UnityEngine;
using Zenject;
public class PlayerShooter : MonoBehaviour
{ 
    [SerializeField] private Weapon _weapon; 
    [SerializeField] private PlayerActionsInput _playerActionsInput;

    public RectTransform _rectTransformAimImage;
    public Camera _camera;

    public bool _couldown;

    [Inject]
    public void Construct( Camera CameraPlayer)  
    { 
        _camera = CameraPlayer;
    }

    private void Start()
    {
        _playerActionsInput = GetComponent<PlayerActionsInput>();
    }

    private void Update()
    {
        Debug.DrawRay(_camera.transform.position, _rectTransformAimImage.position, Color.red);
    }

    public void Shoot()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(_rectTransformAimImage.position);

        if (Physics.Raycast(ray, out hit, 1000) == true)
        {
            _weapon.FirePointLookAt(hit.point);
        }
        if (_playerActionsInput.AttackPressed == true)
        { 
            if (_couldown == false)
            {
                StartCoroutine(Couldown());
                _weapon.Fire();
            }
            
        }
    }

    public IEnumerator Couldown()
    {
        _couldown = true;
        yield return new WaitForSeconds(0.2f);
        _couldown = false;
    }
}
