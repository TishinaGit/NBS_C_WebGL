using Controller;
using UnityEngine;
using Zenject;


public class AIDrone : MonoBehaviour
{ 
    [SerializeField] private float _angryDistance;
    [SerializeField] private Drone _drone;
    
    public Transform _shootTarget;
    
    private Vector3 _movementPosition;
    public Transform _player;
    public CubeArea _movementArea;

    [Inject] public void Construct(PlayerController PlayerPrefab, CubeArea cubeAreaObj)
    {
        _player = PlayerPrefab.transform;
        _movementArea = cubeAreaObj;
    }

    private void Start()
    { 
        _drone.EventOnDeath.AddListener(OnDroneDeath);  
    }

    private void OnDestroy()
    {
        _drone.EventOnDeath.RemoveListener(OnDroneDeath);
    }

    private void Update()
    {
        UpdateAI();
    }

    private void OnDroneDeath()
    {
        enabled = false;
    }

    private void UpdateAI()
    {
        if (transform.position == _movementPosition)
        {
            _movementPosition = _movementArea.GetRandomInsideZone();
        }

        if (Physics.Linecast(transform.position, _movementPosition) == true) 
        {
            _movementPosition = _movementArea.GetRandomInsideZone();
        }

        if(_player != null)
        {
            if (Vector3.Distance(transform.position, _player.position) < _angryDistance)
            {
                _shootTarget = _player;
            }
        }
       

        _drone.MoveTo(_movementPosition);

        if (_shootTarget != null )
        {
            _drone.LookAt(_shootTarget.position);
        }
        else
        {
            _drone.LookAt(_movementPosition);
        }

        if (_shootTarget != null )
        {
            _drone.Fire(_shootTarget.position); 
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _angryDistance);
    }
#endif
}