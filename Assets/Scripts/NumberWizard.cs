using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int numberguesses = 10;
	public Text guessText;
	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1001;
		min = 1;
		guess = 500;
	}

	void NextGuess(){
		guess = (max+min)/2;
		guessText.text = guess.ToString();
		numberguesses--;
		if (numberguesses <= 0) {
			Application.LoadLevel ("Win");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			print("Up arrow");
			guessHigher();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			print("Down arrow");
			guessLower ();
		}
	}

	public void guessHigher(){
		min = guess;
		NextGuess();
	}

	public void guessLower(){
		max = guess;
		NextGuess();
	}
}
