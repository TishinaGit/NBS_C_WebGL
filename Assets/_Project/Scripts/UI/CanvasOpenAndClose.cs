using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CanvasOpenAndClose : MonoBehaviour
{
    [SerializeField] private List<Canvas> _uiCanvas;

    [Inject]
    public void Construct(List<Canvas> AllLabCanvas)
    {
        _uiCanvas = AllLabCanvas;
    } 

    public void OpenCanvas(int IndexGameObject)
    {
        _uiCanvas[IndexGameObject].gameObject.SetActive(true);
    }

    public void CloseCanvas(int IndexGameObject)
    {
        _uiCanvas[IndexGameObject].gameObject.SetActive(false);
    }
}

    
    
    
    
    
     
     