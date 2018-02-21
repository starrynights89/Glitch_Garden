using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
	
	int max;
    int min;
	int guess;
    // Use this for initialization
    void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
    	min = -10;
    	guess = 500;

	    print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down = lower, enter = equal");

		max = max + 1;
		min = min - 1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print("Up arrow pressed");
			min = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
	}

	void NextGuess() {
		guess = (max + min) / 2; //set the guess halfway between the max and the min
		print ("Higher or lower than " + guess);
		print ("Up arrow = higher, down = lower, enter = equal");
	}
}