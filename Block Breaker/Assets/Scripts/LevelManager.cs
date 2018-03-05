﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Start() {

	}

	public void LoadLevel(string name) {
		Debug.Log("Level load requested for: "+name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest() {
		Debug.Log("I want to quit!");
		Application.Quit();
	}

	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
