using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour {
	public Text subText;
	// Use this for initialization
	void Start () {
		if (NumberSettings.settings != null) {
			subText.text = "Pick a number between " + NumberSettings.settings.min.ToString() + " and " + NumberSettings.settings.max.ToString() + " and press Start To Play!";
		}
		else {
			subText.text = "Pick a number between 1 and 1000 and press Start To Play!";
		}

		Debug.Log (subText.text.ToString());
		Debug.Log(NumberSettings.settings.max.ToString());
	}


}
