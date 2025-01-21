using Controller;
using System.Collections;
using UnityEngine;
using Zenject;

public class PortalDome : MonoBehaviour
{
    public GameObject _dome;
    public bool _isActive = false;

    public Collider _playerCollider;

    [Inject]
    public void Construct(Collider PlayerCollider)
    {
        _playerCollider = PlayerCollider;
    }
     
    private void Update()
    { 
        if (_isActive == true)
        {
            _dome.transform.localScale = Vector3.Lerp(_dome.transform.localScale, new Vector3(7, 7, 7),   Time.deltaTime);
        } 
    }
    private void OnTriggerStay(Collider other)
    { 
        if (_playerCollider != null)
        { 
            if (Input.GetKey(KeyCode.E))
            { 
                _isActive = true;
            }
        }
    } 
}
