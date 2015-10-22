using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class NumberSettings : MonoBehaviour {

	public static NumberSettings settings; // Singleton-like implementation - THERE CAN BE ONLY ONE!

	#region Controls UI
	public Slider diffSlider;
	public Text diffValue;
	public InputField maxInput;
	public InputField minInput;
	#endregion
	
	#region Properties
	// Default values (in case the settings-screen never gets opened)
	public static int defDiff = 10;
	public static int defMin = 1;
	public static int defMax = 1000;
	//modifiable properties
	public int diff = 10;
	public int min = 1;
	public int max = 1000;
	#endregion

	#region Start() and Awake() methods
	// Use this for initialization
	void Start ()
	{

	}

	// "Properly" implemented Persistent Singleton Pattern
	// if there is already an instance of NumberSettings, destroy the GameObject which tries to make a new instance.
	// otherwise, claim the instance and make it persistent through the levels.
	void Awake(){
		if (settings != null) {
			Destroy(gameObject);
		}
		else
		{
			settings = this;
			DontDestroyOnLoad(gameObject);
		}
		diffSlider.value	= int.Parse (settings.diff.ToString ()); 			//
		minInput.text 		= settings.min.ToString ();					// All this sets the UI elements to the saved (previously used) values should 
		maxInput.text 		= settings.max.ToString ();					// they have been changed in a previous playthrough.
	}
	#endregion


	#region Functionality
	// Saves the setings
	public void saveSettings ()
	{
		diff = (int)diffSlider.value;
		min = Int32.Parse (minInput.text.ToString ());
		max = Int32.Parse (maxInput.text.ToString ());
	}

	// Updates the text-field next to the slider bar in the settings screen
	public void updateDiffValue ()
	{
		diffValue.text = diffSlider.value.ToString ();
	}
	#endregion


}
