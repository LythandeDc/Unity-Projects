using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		int max  = 1000;
		int min = 1;
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than 500?");
		print ("up arrow for higher, down for lower, return for equal");
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed");
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			print ("Down arrow pressed");
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I won");
		}
	}
}
