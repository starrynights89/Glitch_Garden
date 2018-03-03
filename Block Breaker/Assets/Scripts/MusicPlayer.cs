using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	void Start() {
		GameObject.DontDestroyOnLoad(transform.root.gameObject);
	}
}
