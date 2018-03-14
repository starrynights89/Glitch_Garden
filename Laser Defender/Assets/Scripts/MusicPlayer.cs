using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null; //static instance of music player

	public AudioClip startClip;
	public AudioClip gameClip;
	public AudioClip endClip;

	void Awake()
	{
		Debug.Log ("Music player Awake " + GetInstanceID());
		if (instance != null && instance != this) {
			Destroy (gameObject); //destroy object if instance isn't null
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this; 
			GameObject.DontDestroyOnLoad(transform.root.gameObject); //don't destroy if first 
		}															// instance is running
	}

	void Start() {
		Debug.Log ("Music player Start " + GetInstanceID());
	}  
}
