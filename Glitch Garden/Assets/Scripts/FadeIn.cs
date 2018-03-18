using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public float fadeTime = 5f;
	
	// Use this for initialization
	void Start () {
		GetComponent<Image>().CrossFadeAlpha(0f, fadeTime, false);
		Invoke("SetAsInactive", fadeTime);
	}

	void SetAsInactive() {
		gameObject.SetActive(false);
	}
}
