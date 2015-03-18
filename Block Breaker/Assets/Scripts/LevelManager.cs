using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("New Level load: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log ("Quitting game");
		Application.Quit();
	}
}
