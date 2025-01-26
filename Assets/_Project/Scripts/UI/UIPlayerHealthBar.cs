using UnityEngine;
using UnityEngine.UI; 

public class UIPlayerHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _uiHealthBar;
     
    public void CheckHpBar(int CurrentHitPoints, int MaxHealthPoints)
    {
        _uiHealthBar.value = CurrentHitPoints / 100f;
    }
}