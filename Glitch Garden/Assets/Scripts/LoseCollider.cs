using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private SceneController LevelManager; 

	void OnTriggerEnter2D() {
		LevelManager = GameObject.FindObjectOfType<SceneController>();
		LevelManager.LoadLevel("03b Lose");
	}
}
