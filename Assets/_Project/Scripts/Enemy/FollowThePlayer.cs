using UnityEngine;
using Zenject;

public class FollowThePlayer : MonoBehaviour
{ 
    [SerializeField] private Transform _playerTransform;

    [Inject]
    public void Construct(Transform TransformCamera)
    {
        _playerTransform = TransformCamera;
    }
    void Update()
    {
        gameObject.transform.position = _playerTransform.position;
    }
}
