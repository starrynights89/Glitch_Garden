using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null; //static instance of music player

	public AudioClip startClip;
	public AudioClip gameClip;
	public AudioClip endClip;

	private AudioSource music;

	void Awake()
	{
		Debug.Log ("Music player Awake " + GetInstanceID());
		if (instance != null && instance != this) {
			Destroy (gameObject); //destroy object if instance isn't null
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this; 
			//don't destroy if first instance is running
			GameObject.DontDestroyOnLoad(transform.root.gameObject);
			music = GetComponent<AudioSource>();
			music.clip = startClip;
			music.loop = true;
			music.Play();
		}														
	}

	void OnLevelWasLoaded(int level) {
		Debug.Log("MusicPlayer: loaded level "+level);
		music.Stop();
		
		if(level == 0) {
			music.clip = startClip;
		}
		if(level == 1) {
			music.clip = gameClip;
		}
		if(level == 2) {
			music.clip = endClip;
		}
		music.loop = true;
		music.Play();
	} 

	void Start() {
		Debug.Log ("Music player Start " + GetInstanceID());
	}  
}
