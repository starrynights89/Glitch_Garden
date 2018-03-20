using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSecondsLizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Appearing());
	}

	IEnumerator Appearing() {
		print(Time.time);
		yield return new WaitForSeconds(1);
		print(Time.time);
	}
}
