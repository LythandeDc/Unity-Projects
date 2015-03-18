using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer INSTANCE = null;

	void Awake () {
		Debug.Log ("Music player Awake " + GetInstanceID());
		if(INSTANCE != null){
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		}else {
			INSTANCE = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Music player Start " + GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
