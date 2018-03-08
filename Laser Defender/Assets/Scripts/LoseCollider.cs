using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private SceneController levelManager;
	void OnTriggerEnter2D(Collider2D trigger)
	{
		levelManager = GameObject.FindObjectOfType<SceneController>();
		levelManager.LoadSceneAsync("Loose Screen");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Collision");
	}
}
