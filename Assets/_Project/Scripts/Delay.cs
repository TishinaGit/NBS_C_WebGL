using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject SceneInstaller;
    public GameObject LoadingCanvas; 
    public GameObject CameraSystem;
    public GameObject LabCanvas;
    public float r = 0;
    void Update()
    {
        if (r < 4)
        {
            r += Time.deltaTime;
        }
        else 
        {
            if (SceneInstaller != null) 
            {
                SceneInstaller.SetActive(true);
                
            }  
            if (CameraSystem != null)
            {
                CameraSystem.SetActive(true);
            }
            if (LabCanvas != null)
            {
                LabCanvas.SetActive(true);
            }
            Destroy(LoadingCanvas);
        } 
    }
}
