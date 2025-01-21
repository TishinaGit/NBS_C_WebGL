using UnityEngine;
using UnityEngine.UI; 

public class UIPlayerHealthBar : MonoBehaviour
{
    [SerializeField] private Image _uiHealthBar;

    private void Start()
    {
        _uiHealthBar.fillAmount = 1f;
    }
    public void CheckHpBar(int CurrentHitPoints, int MaxHealthPoints)
    {
        _uiHealthBar.fillAmount = CurrentHitPoints / 100f;
    }
}