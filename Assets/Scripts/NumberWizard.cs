using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization

	public Text guessText;
	
	int max = 1000;
	int min = 1;
	int guess;
		
	void Start () {
		StartGame();
	}

	void StartGame () {
		max = max + 1;
		NextGuess();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();		
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();		
	}
	
	public void GuessCorrect() {
		StartGame();		
	}
	
	void NextGuess () {
		//guess = (max + min) / 2;
		guess = Random.Range(min, max);
		guessText.text = guess.ToString();
		print ("Next guess is " + guess);
	}
	
}
