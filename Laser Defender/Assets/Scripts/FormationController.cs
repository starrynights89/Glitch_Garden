﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationController : MonoBehaviour {
	public GameObject enemyPrefab;
	public float width = 10f;
	public float height = 5f;
	public float speed = 5f;

	private bool movingRight = true;
	private float xmax;
	private float xmin;

	// Use this for initialization
	void Start () {
		float distanceToCamera = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distanceToCamera));
		Vector3 rightBoundary = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distanceToCamera));
		xmax = rightBoundary.x;
		xmin = leftBoundary.x;
		SpawnEnemies();
	}

	void SpawnEnemies() {
		foreach( Transform child in transform ) {
			GameObject enemy = Instantiate(enemyPrefab, child.transform.position,
			Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}
	}

	public void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
	}
	
	// Update is called once per frame
	void Update () {
		if(movingRight) {
			transform.position += Vector3.right * speed*Time.deltaTime;
		} else {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		//Check if the formation is going outside the playspace...
		float rightEdgeOfFormation = transform.position.x + (0.5f*width);
		float leftEdgeOfFormation = transform.position.x - (0.5f*width);
		if(leftEdgeOfFormation < xmin) {
			movingRight = true;
		} else if(rightEdgeOfFormation > xmax) {
			movingRight = false;
		}

		if(AllMembersDead()) {
			Debug.Log("Empty Formation");
		}
	}

	bool AllMembersDead() { //for each child position object, count the number of objects 
							//until child count is 0
		foreach(Transform childPositionGameObject in transform) {
			if (childPositionGameObject.childCount > 0) {
				return false;
			}
		}
		return true;
	}
}
