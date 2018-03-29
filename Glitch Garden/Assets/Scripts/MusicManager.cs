using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;
    
    // Use this for initialization
    void Awake() {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);
	}
	 void Start() { //link the audiosource to the audio source component in persistent music object
		audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }

    /*void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }*/

	void OnLevelWasLoaded(int level) {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];

		Debug.Log("Playing clip: " + thisLevelMusic);

        if (thisLevelMusic) { // If there's some music attached 
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
	}

    public void SetVolume(float volume) { //save value of changed volume
        audioSource.volume = volume;
    }
}