using System.Collections;
using TMPro;
using UnityEngine; 
using Zenject;

public class ScoreInTrigger : MonoBehaviour
{ 
    [SerializeField] private GameObject _portal;
    private float _score;
    public Collider _playerCollider;
    private TMP_Text _uiScoreText;

    private IEnumerator metodScore;
    private bool _isTrigger;

    [Inject]
    public void Construct(Collider PlayerCollider, TMP_Text UIScoreText)
    {
        _playerCollider = PlayerCollider;
        _uiScoreText = UIScoreText;
    }

    private void Start()
    {
         metodScore = Scoreplus();
    }

    private void Update()
    {
        if (_isTrigger == true)
        {
            _score += 10 * Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    { 
        StartCoroutine(metodScore); 
        _isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    { 
        StopCoroutine(metodScore); 
        _isTrigger = false;
    }

    private IEnumerator Scoreplus()
    { 
        while (_score < 101)
        {
            _isTrigger = true;
            var integer = (int)_score;
            _uiScoreText.text = "Активация портала: " + integer.ToString() + "%";
            if (_score >= 100)
            {
                Debug.Log("1");
                _isTrigger = false;
                _portal.SetActive(true); 
            }
            yield return null;
        }
    }
}
