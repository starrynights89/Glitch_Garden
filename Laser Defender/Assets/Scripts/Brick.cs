using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	public static int breakableCount = 0;
	public Sprite[] hitSprites;
	public GameObject smoke;
	
	private int timesHit;
	private SceneController levelManager;
	private bool isBreakable;
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		//Keep track of breakable bricks
		if (isBreakable) {
			breakableCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<SceneController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D (Collision2D col) {
        AudioSource.PlayClipAtPoint(crack, transform.position, 0.8f);
		if (isBreakable) {
			HandleHits();
		}
	}

	void HandleHits () {
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			PuffSmoke();
			Destroy(gameObject);
		} else {
			LoadSprites();
		}
	}

	void PuffSmoke () {
		//we create a variable of type GameObject named smokePuff and give it the value of
		//an instantiated particle effect smoke cloud
		//the smoke has it’s transform set to the instance of the brick that is creating it,
		//as well as the rotation.
		GameObject smokePuff = Instantiate (smoke, transform.position, Quaternion.identity);
		ParticleSystem.MainModule main = smokePuff.GetComponent<ParticleSystem>().main;
		main.startColor = GetComponent<SpriteRenderer>().color;
	}

	void LoadSprites () {
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex] != null) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		} else {
			Debug.LogError("Brick sprite missing");
		}
	}

	// TODO Remove this method once we can actually win!
	void SimulateWin () {
		levelManager.LoadNextSceneAsync();
	}
}
