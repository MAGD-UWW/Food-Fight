using UnityEngine;
using System.Collections;

public class player1Movement : MonoBehaviour {
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform pos4;
	public Transform pos5;
	public ActionManager action; //Added action manager 11/26/15 Eric Olson
	public PlayerOneManager player1; //Added player one manager 11/26/15 Eric Olson
	//string spot;
	string[] moves = new string[3];
	bool p1 = false;
	bool p2 = false;
	bool p3 = false;
	bool p4 = false;
	bool p5 = false;

	void Start(){
		pos1 = GameObject.FindGameObjectWithTag ("position1").transform;
		pos2 = GameObject.FindGameObjectWithTag ("position2").transform;
		pos3 = GameObject.FindGameObjectWithTag ("position3").transform;
		pos4 = GameObject.FindGameObjectWithTag ("position4").transform;
		pos5 = GameObject.FindGameObjectWithTag ("position5").transform;
		action = GameObject.Find("Manager").GetComponent<ActionManager>(); //Added action manager 11/26/15 Eric Olson
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>(); //Added player one manager 11/26/15 Eric Olson
	}
	
	// Update is called once per frame
	void Update () {
		CheckGrid ();
	}

	void CheckGrid(){
		if ((Input.GetKeyDown (KeyCode.Tab)) && (p3 == false) && (p4 == false) && (p5 == false)) { //Changed Keycode A to Tab 11/26/15 Eric Olson
			transform.position = pos1.position;
			p1 = true;
			p2 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			//spot = "a";
			//moves[0] = "a";
			//Debug.Log ("array 1 " + moves[0]);
		}
		if ((Input.GetKeyDown (KeyCode.Q)) && (p4 == false) && (p5 == false)) { //Changed Keycode S to Q 11/26/15 Eric Olson
			transform.position = pos2.position;
			p2 = true;
			p1 = false;
			p3 = false;
			p4 = false;
			p5 = false;
		}
		if ((Input.GetKeyDown (KeyCode.W)) && (p1 == false) && (p5 == false)){ //Changed Keyboard D to W 11/26/15 Eric Olson
			transform.position = pos3.position;
			p3 = true;
			p1 = false;
			p2 = false;
			p4 = false;
			p5 = false;
		}
		if ((Input.GetKeyDown (KeyCode.E)) && (p1 == false) && (p2 == false)){ //Changed Keycode F to E 11/26/15 Eric Olson
			transform.position = pos4.position;
			p4 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p5 = false;
		}
		if ((Input.GetKeyDown (KeyCode.R)) && (p1 == false) && (p2 == false) && (p3 == false)){ //Changed Keycode G to R 11/26/15 Eric Olson
			transform.position = pos5.position;
			p5 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p4 = false;
		}
	}


}
