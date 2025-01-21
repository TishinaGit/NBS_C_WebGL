using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class TakeRedPotion : MonoBehaviour
{  
    [SerializeField] private Image _uiWaterScales;
     
    private float _minusRedPotion_0 = 0.2f;
    private float _minusRedPotion_1 = 0.4f;
    private float _minusRedPotion_2 = 0.6f;

    private DataAddItems _dataAddItems;

    [Inject]
    public void Construct(DataAddItems dataAddItems)
    {
        _dataAddItems = dataAddItems;
    }

    public void BTM_TakeBluePotion_0()
    {
        if (_uiWaterScales.fillAmount > 0.19f)
        {
            _dataAddItems.AddRedPotion_0();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusRedPotion_0;
        }  
    }
    public void BTM_TakeBluePotion_1()
    {
        if (_uiWaterScales.fillAmount > 0.39f)
        {
            _dataAddItems.AddRedPotion_1();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusRedPotion_1;
        }   
    }
    public void BTM_TakeBluePotion_2()
    {
        if (_uiWaterScales.fillAmount > 0.59f)
        {
            _dataAddItems.AddRedPotion_2();
            _uiWaterScales.fillAmount = _uiWaterScales.fillAmount - _minusRedPotion_2;
        }  
    }
}
