using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//Load new level, passes along the name of the level to be loaded
	public void loadNewLevel(string name){
		Debug.Log ("Level load requested, for:" + name);
		Application.LoadLevel(name);
		DontDestroyOnLoad(NumberSettings.settings);
	}

	public void quitRequest(){
		//Debug.Log("Quit requested... should we exit?");
		Application.Quit ();

	}
	
}
