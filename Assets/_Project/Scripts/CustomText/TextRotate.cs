using UnityEngine;
using TMPro;
using Cinemachine; 
using Zenject;

public class TextRotate : MonoBehaviour
{  
    [SerializeField] TMP_Text _text;
    private CinemachineFreeLook _freeLook;

    [Inject] public void Construct(CinemachineFreeLook freeLook)
    {
        _freeLook = freeLook;
    }
     
   public void FixedUpdate()
   { 
        _text.transform.LookAt(_freeLook.transform);
        _text.transform.Rotate(0, 180, 0);  
   }
}
