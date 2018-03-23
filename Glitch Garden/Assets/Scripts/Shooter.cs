using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject projectile, gun;
	
	private GameObject projectileParent;
	private Animator animator;
	private AttackerSpawner myLaneSpawner;

	void Start () {
		animator = GetComponent<Animator>();

		projectileParent = GameObject.Find("Projectiles");

		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
	}

	void Update () {
		if (isAttackerAheadInLane()) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}

	// Look through all spawners, and set myLaneSpawner if found
	void setMyLaneSpawner () {
		//Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();
	}

	bool isAttackerAheadInLane() {
		return false;
	}

	private void Fire() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position;
	}
}
