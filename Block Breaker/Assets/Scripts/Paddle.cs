using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	
	private Ball ball;

	// Use this for initialization
	void Start () {
		ball = Object.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(autoPlay){
			MoveRobot();
		}else {
			MoveWithMouse();
		}
	}
	
	void MoveRobot(){
		Vector3 paddlePos = new Vector3( ball.transform.position.x, this.transform.position.y, 0f);
		this.transform.position = paddlePos;
	}
	
	void MoveWithMouse() {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		mousePosInBlocks = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		Vector3 paddlePos = new Vector3( mousePosInBlocks, this.transform.position.y, 0f);
		
		this.transform.position = paddlePos;
	}
}
