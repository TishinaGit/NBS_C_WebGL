 
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextGameSceneLevel : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameScene_LvlOne");
        } 
    }
}
