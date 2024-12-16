using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneToLoad = "lboyd_Final";


    public void LoadGameLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
