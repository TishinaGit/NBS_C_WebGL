using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class TakeBluePotion : MonoBehaviour
{
    [SerializeField] private Image _uiWaterScales;

    private float _minusBluePotion_0 = 0.2f;
    private float _minusBluePotion_1 = 0.4f;
    private float _minusBluePotion_2 = 0.6f;

    private DataAddItems _dataAddItems;

    [Inject]
    public void Construct(DataAddItems dataAddItems)
    { 
        _dataAddItems = dataAddItems;
    }

    private void Awake()
    {
        if (_uiWaterScales != null)
        {
            _uiWaterScales.fillAmount = 1f;
        } 
    } 

    public void BTM_TakeBluePotion_0()
    {
        if (_uiWaterScales.fillAmount > 0.19f)
        { 
            _dataAddItems.AddBluePotion_0();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusBluePotion_0; 
        }  
    }
    public void BTM_TakeBluePotion_1()
    {
        if (_uiWaterScales.fillAmount > 0.39f)
        {
            _dataAddItems.AddBluePotion_1();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusBluePotion_1; 
        } 

    }
    public void BTM_TakeBluePotion_2()
    {
        if (_uiWaterScales.fillAmount > 0.59f)
        {
            _dataAddItems.AddBluePotion_2();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusBluePotion_2; 
        }  
    }
}
