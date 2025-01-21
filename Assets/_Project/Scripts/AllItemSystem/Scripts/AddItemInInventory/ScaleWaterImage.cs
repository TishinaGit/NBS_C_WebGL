using UnityEngine;
using UnityEngine.UI; 

public class ScaleWaterImage : MonoBehaviour
{
    [SerializeField] private Image _uiWaterScales;
      
    private void Update()
    {
        if (_uiWaterScales.fillAmount < 1f)
        {
            _uiWaterScales.fillAmount += 0.05f * Time.deltaTime;
        }
    } 
}