using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLoadGameScene : MonoBehaviour
{
    [SerializeField] private int _level;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other != null)
            {
                SceneManager.LoadScene(_level);
            }
        }
       
    }
}
