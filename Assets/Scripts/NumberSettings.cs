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
	// Default values
	public int diff = 10;
	public int min = 1;
	public int max = 1000;
	#endregion

	#region Start() method
	// Use this for initialization
	void Start ()
	{
		settings 			= (settings == null) ? this : settings; 	// Instances NumberSettings if it does not yet exist

		diffSlider.value	= int.Parse (settings.diff.ToString ()); 	//
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
		Debug.Log (settings.diff.ToString ());
		Debug.Log (settings.min.ToString ());
		Debug.Log (settings.max.ToString ());
	}

	// Updates the text-field next to the slider bar in the settings screen
	public void updateDiffValue ()
	{
		diffValue.text = diffSlider.value.ToString ();
	}
	#endregion


}
