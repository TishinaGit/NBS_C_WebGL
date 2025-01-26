using System.Collections;
using TMPro;
using UnityEngine; 
using Zenject;

public class ScoreInTrigger : MonoBehaviour
{ 
    [SerializeField] private GameObject _portalHome;
    [SerializeField] private GameObject _portalNextGame;

    private TMP_Text _uiScoreText;

    private float _score = 0f; 

    [Inject]
    public void Construct(TMP_Text UIScoreText)
    { 
        _uiScoreText = UIScoreText;
    } 
 
    private void OnTriggerStay(Collider other)
    { 
        StartCoroutine(Scoreplus());  
    }
     
    private IEnumerator Scoreplus()
    {
        if (_score >= 100)
        {
            _portalNextGame.SetActive(true);
            _portalHome.SetActive(true);
        }

        while (_score <= 100)
        {
            _score += 0.01f * Time.deltaTime;
            var integer = (int)_score;
            _uiScoreText.text = "Активация портала: " + integer.ToString() + "%";
            yield return null;
        } 
    }
     
}
