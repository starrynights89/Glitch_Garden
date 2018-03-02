using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    	NextGuess();
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
		guess = Random.Range(min, max+1);
		maxGuessesAllowed = maxGuessesAllowed - 1; 
		text.text = guess.ToString();
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}
	}
}