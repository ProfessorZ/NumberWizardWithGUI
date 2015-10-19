using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class NumberSettings : MonoBehaviour {
	public static NumberSettings settings;

	public Slider diffSlider;

	// public Text minInput;
	public InputField maxInput;
	public Text diffValue;

	public InputField minInput;
	public int diff = 10;
	public int min = 1;
	public int max = 1000;

	// Use this for initialization
	
	void Start(){
		//settings = this;
		//
		settings = (settings == null) ? this : settings;
		diffSlider.value = int.Parse(settings.diff.ToString());
		minInput.text = settings.min.ToString();
		maxInput.text = settings.max.ToString();
		//Debug.Log (minInput.text.ToString ());
	}
	
	public void Awake(){
		//DontDestroyOnLoad(this);
	}

	public void saveSettings(){
		diff = (int) diffSlider.value;
		min =  Int32.Parse(minInput.text.ToString());
		max = Int32.Parse(maxInput.text.ToString());
		Debug.Log(settings.diff.ToString());
		Debug.Log(settings.min.ToString());
		Debug.Log(settings.max.ToString());
	}

	public void updateDiffValue(){
		diffValue.text = diffSlider.value.ToString();
	}


}
