﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

	public float levelSeconds = 100;

	private Slider slider;
	private AudioSource audioSource;
	private bool isEndOfLevel = false;
	private SceneController LevelManager;
	private GameObject winLabel;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		LevelManager = GameObject.FindObjectOfType<SceneController>();
		FindYouWin();
		winLabel.SetActive(false);
	}

	void FindYouWin() {
		winLabel = GameObject.Find("You Win");
		if (!winLabel) {
			Debug.LogWarning ("Please create You Win object");
		}
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;

		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if (timeIsUp && !isEndOfLevel) {
			HandleWinCondition();
		}
	}

	void HandleWinCondition() {
		DestroyAllTaggedObjects();
		audioSource.Play();
		winLabel.SetActive(true);
		Invoke ("LoadNextLevel", audioSource.clip.length);
		isEndOfLevel = true;
	}

	//Destroys all objects with destroyOnWin tag
	void DestroyAllTaggedObjects() {
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag("destroyOnWin");

		foreach (GameObject taggedObject in taggedObjectArray) {
			Destroy (taggedObject);
		}
	}

	void LoadNextLevel() {
		LevelManager.LoadNextLevel();
	}
}
