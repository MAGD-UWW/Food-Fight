using UnityEngine;
using System.Collections;

public class player2Move : MonoBehaviour {
	public Transform pos6;
	public Transform pos7;
	public Transform pos8;
	public Transform pos9;
	public Transform pos10;

	bool p2Move = false; // set to false so have to activate it to allow movement
	bool p6 = false;
	bool p7 = false;
	bool p8 = false;
	bool p9 = false;
	bool p10 = false;
	
	void Start(){
		pos6 = GameObject.FindGameObjectWithTag ("position6").transform;
		pos7 = GameObject.FindGameObjectWithTag ("position7").transform;
		pos8 = GameObject.FindGameObjectWithTag ("position8").transform;
		pos9 = GameObject.FindGameObjectWithTag ("position9").transform;
		pos10 = GameObject.FindGameObjectWithTag ("position10").transform;
	}
	
	// Update is called once per frame
	void Update () {
		CheckGrid ();
	}
	
	void CheckGrid(){
		if (Input.GetKey (KeyCode.K)) {
			p2Move = true;
		}

		if ((p2Move == true) && (Input.GetKeyDown (KeyCode.I)) && (p8 == false) && (p9 == false) && (p10 == false)) {
			transform.position = pos6.position;
			p6 = true;
			p7 = false;
			p8 = false;
			p9 = false;
			p10 = false;
			p2Move = false;// set move option to false so player has to press it again
			//spot = "a";
			//moves[0] = "a";
			//Debug.Log ("array 1 " + moves[0]);
		}
		if ((p2Move == true) && (Input.GetKeyDown (KeyCode.O)) && (p9 == false) && (p10 == false)) {
			transform.position = pos7.position;
			p7 = true;
			p6 = false;
			p8 = false;
			p9 = false;
			p10 = false;
			p2Move = false;
		}
		if ((p2Move == true) && (Input.GetKeyDown (KeyCode.P)) && (p6 == false) && (p10 == false)){
			transform.position = pos8.position;
			p8 = true;
			p6 = false;
			p7 = false;
			p9 = false;
			p10 = false;
			p2Move = false;
		}
		if ((p2Move == true) && (Input.GetKeyDown (KeyCode.LeftBracket)) && (p6 == false) && (p7 == false)){
			transform.position = pos9.position;
			p9 = true;
			p6 = false;
			p7 = false;
			p8 = false;
			p10 = false;
			p2Move = false;
		}
		if ((p2Move == true) && (Input.GetKeyDown (KeyCode.RightBracket)) && (p6 == false) && (p7 == false) && (p8 == false)){
			transform.position = pos10.position;
			p10 = true;
			p6 = false;
			p7 = false;
			p8 = false;
			p9 = false;
			p2Move = false;
		}
	}
}
