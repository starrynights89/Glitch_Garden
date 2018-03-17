using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    static MusicManager instance = null; //static instance of music player
    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;
    // Use this for initialization

    void Awake() {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);
	}
	 void Start() {
		audioSource = GetComponent<AudioSource>();
    }

    void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

	void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		Debug.Log("Playing clip: " + levelMusicChangeArray);
	}
}