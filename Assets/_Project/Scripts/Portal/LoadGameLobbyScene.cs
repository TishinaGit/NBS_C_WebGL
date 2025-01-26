using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameLobbyScene : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other != null)
            {
                BTN_SceneLobbyLoad();
            }
        }

    }

    public void BTN_SceneLobbyLoad()
    {
        SceneManager.LoadScene(1);
    }

}
