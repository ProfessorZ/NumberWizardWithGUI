using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int difficulty;
	int numberguesses;
	public Text guessText;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		setMax(NumberSettings.settings.max);
		setMin(NumberSettings.settings.min);
		guess = Random.Range (min,max);
		guessText.text = guess.ToString();
		setDiff((int)NumberSettings.settings.diff);
		numberguesses = difficulty;
		Debug.Log ("Difficulty: " +getDiff().ToString() + "/" + NumberSettings.settings.diff.ToString() + " -- Min:" + getMin().ToString() + " -- Max:" + getMax().ToString());
	}

	void NextGuess(){
		//guess = (max+min)/2;
		guess = Random.Range (min,max);
		guessText.text = guess.ToString();
		numberguesses--;
		Debug.Log ("number of guesses left:" + numberguesses.ToString());
		Debug.Log ("Difficulty: " +getDiff().ToString() + " -- Min:" + getMin ().ToString() + " -- Max:" + getMax().ToString());
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

	#region getters and setters
	public void setDiff(int diff){
		numberguesses = diff;
		difficulty = diff;
	}
	public void setMin(int min){
		this.min = min;
	}
	public void setMax(int max){
		this.max = max;
	}
	public int getDiff(){
		return this.difficulty;
	}
	public int getMin(){
		return this.min;
	}
	public int getMax(){
		return this.max;
	}
	#endregion


}
