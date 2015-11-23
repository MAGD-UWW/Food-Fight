using UnityEngine;
using System.Collections;

public class player2Throw : MonoBehaviour {

	bool p2Throw = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ThrowAtGrid ();
	}
	void ThrowAtGrid(){
		if (Input.GetKey (KeyCode.Semicolon)) {
			p2Throw = true;
		}
		
		if ((p2Throw == true) && (Input.GetKey (KeyCode.I))){
			Debug.Log("throw at position 1");
			p2Throw = false;
			// food.position = pos1.position;
		}
		
		if ((p2Throw == true) && (Input.GetKey (KeyCode.O))){
			Debug.Log("throw at position 2");
			// food.position = pos2.position;
			p2Throw = false;
		}
		
		if ((p2Throw == true) && (Input.GetKey (KeyCode.P))){
			Debug.Log("throw at position 3");
			p2Throw = false;
			// food.position = pos1.position;
		}
		
		if ((p2Throw == true) && (Input.GetKey (KeyCode.LeftBracket))){
			Debug.Log("throw at position 4");
			p2Throw = false;
			// food.position = pos1.position;
		}
		if ((p2Throw == true) && (Input.GetKey (KeyCode.RightBracket))){
			Debug.Log("throw at position 5");
			p2Throw = false;
			// food.position = pos1.position;
		}
	}
}
