using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundSettings : MonoBehaviour
{
	public string sceneToLoad = "Sound_Music_Settings";


	public void LoadSounds ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
