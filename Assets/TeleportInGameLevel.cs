using Controller;
using UnityEngine;
using Zenject;

public class TeleportInGameLevel : MonoBehaviour
{
    [SerializeField] private Transform[] _teleportPoints;

    public GameObject _playerController;
    //[Inject] public void Construct(PlayerController playerController)
    //{
    //    _playerController = playerController;
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Teleport();
        }
    }

    public void Teleport()
    {
         var randomPoint = Random.Range(0, _teleportPoints.Length -1); 
         _playerController.gameObject.transform.position = _teleportPoints[randomPoint].position;
    }
}
