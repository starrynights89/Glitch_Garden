using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private SceneController LevelManager;

	void Start() {
		LevelManager = GameObject.FindObjectOfType<SceneController>();
	} 

	void OnTriggerEnter2D() {
		LevelManager.LoadLevel("03b Lose");
	}
}
