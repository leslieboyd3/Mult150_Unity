using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Sound_Music_Settings";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
