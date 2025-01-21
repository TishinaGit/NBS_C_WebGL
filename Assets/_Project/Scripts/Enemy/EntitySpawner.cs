using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EntitySpawner : MonoBehaviour
{
	public enum SpawnMode
	{
		Start,
		Loop
	}

	[SerializeField] private List<Entity> _entityPrefab;
	[SerializeField] private CubeArea _area;
	[SerializeField] private SpawnMode _spawnMode;
	[SerializeField] private int _numSpawn;
	[SerializeField] private float _respawnTime;
	
	[Inject] private DiContainer _diContainer;
	 
	private float _timer; 

	private void Start()
	{
		if (_spawnMode == SpawnMode.Start) SpawnEntities();
		  
		_timer = _respawnTime;
	}

	private void Update()
	{
		if (_timer >= 0) _timer -= Time.deltaTime;

		if (_spawnMode == SpawnMode.Loop && _timer < 0)
		{
			SpawnEntities();
			 
			_timer = _respawnTime;
		}
	}

	private void SpawnEntities()
	{
		var positionEnemy = transform.position;
		for (int i = 0; i < _numSpawn; i++)
		{ 
			int index = Random.Range(0, _entityPrefab.Count);
            positionEnemy = _area.GetRandomInsideZone(); 
            _diContainer.InstantiatePrefab(_entityPrefab[index], positionEnemy, Quaternion.identity, null); 
		}

	}
}
