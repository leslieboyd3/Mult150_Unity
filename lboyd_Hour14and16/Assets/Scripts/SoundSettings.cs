using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundSettings : MonoBehaviour
{
	public string sceneToLoad = "lboyd_Final";


	public void LoadSounds ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
