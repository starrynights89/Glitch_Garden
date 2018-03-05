using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("Level load requested for: "+name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest() {
		Debug.Log("I want to quit!");
		Application.Quit();
	}

	public void LoadNextLevel() {
		Scene current = SceneManager.GetActiveScene();
		int loadedLevel = current.loadedLevel + 1;
		SceneManager.LoadScene(SceneManager.loadedLevel + 1)
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
