 using UnityEngine;
using Zenject;

public class RandomSpawnGamePortal : MonoBehaviour
{
    [SerializeField] private GameObject _gamePortal;
    [SerializeField] private Transform[] _spawnTarget;

    [Inject] private DiContainer _diContainer;
     
    private void RandomSpawn()
    { 
        int randomPoint = Random.Range(0, _spawnTarget.Length);
        _diContainer.InstantiatePrefab(_gamePortal, _spawnTarget[randomPoint].transform);
       
    }

    private void Start()
    {
        RandomSpawn();
    }
}
