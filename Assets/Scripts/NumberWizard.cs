using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	#region variables
	int max;
	int min;
	int guess;
	int difficulty;
	int numberguesses;
	public Text guessText;
	#endregion

	#region Start() and Update()
	// Use this for initialization
	void Start ()
	{
		//sets the values to the settings, or if the settings-scene never got opened, loads the default static values.
		setMax((NumberSettings.settings != null) ? NumberSettings.settings.max : NumberSettings.defMax);
		setMin((NumberSettings.settings != null) ? NumberSettings.settings.min : NumberSettings.defMin);
		setDiff((NumberSettings.settings != null) ?(int)NumberSettings.settings.diff : NumberSettings.defDiff);

		guess = Random.Range (min, max+1);
		guessText.text = guess.ToString ();
		numberguesses = difficulty;
	}

	// Update is called once per frame
	void Update ()
	{

	}
	#endregion

	#region Functionality
	void NextGuess ()
	{
		//guess = (max+min)/2;
		guess = Random.Range (min, max+1);
		guessText.text = guess.ToString ();
		numberguesses--;
		if (numberguesses <= 0) {
			Application.LoadLevel ("Win");
		}
	}

	public void guessHigher (){
		min = guess;
		NextGuess ();
	}

	public void guessLower (){
		max = guess;
		NextGuess ();
	}
	#endregion

	#region Modifiers
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
