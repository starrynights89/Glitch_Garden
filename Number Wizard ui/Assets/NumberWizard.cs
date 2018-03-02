using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	int max;
    int min;
	int guess;
	
	public int maxGuessesAllowed = 5;
	public Text text;
    // Use this for initialization
    void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
    	min = -10;
    	guess = 500;

		max = max + 1;
		min = min - 1;
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	void NextGuess() {
		guess = (max + min) / 2; //set the guess halfway between the max and the min
		maxGuessesAllowed = maxGuessesAllowed - 1; 
		text.text = guess.ToString();
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}