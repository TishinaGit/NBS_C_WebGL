using Controller;
using System.Collections;
using UnityEngine;
using Zenject;

public class AddItem : MonoBehaviour 
{ 
    [SerializeField] private GameObject _dropItem; 
     
    public Transform _player;
    public DataAddItems _dataAddItems;
    private bool _checkDeathEnemy;

    [Inject]
    public void Construct(PlayerController playerController, DataAddItems DataAddItems)  
    { 
        _player = playerController.transform;
        _dataAddItems = DataAddItems;
    } 

    private void Update()
    {
        StartCoruoutineDeath(); 
    }

    private void StartCoruoutineDeath()
    {
        if (_checkDeathEnemy == true)
        {
            if (_dropItem != null)
            {
                StopCoroutine(MoveObject());
            }
            StartCoroutine(MoveObject());
        }

    }

    public void EnemyDeathBool()
    {
        _checkDeathEnemy = true;
    }

    public IEnumerator MoveObject()
    { 
        float currentMovementTime = 0.1f;
        _dropItem.transform.parent = null;
        while (Vector3.Distance(_dropItem.transform.position, _player.transform.position) > 0 && _dropItem != null)
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(_dropItem.transform.position, _player.transform.position, currentMovementTime * Time.deltaTime );
            yield return null;
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AddItems();
            Destroy(_dropItem);  
        }
    }

    private void AddItems()
    {
        _dataAddItems.AddBlood();
    }
}
