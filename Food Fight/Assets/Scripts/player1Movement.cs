using UnityEngine;
using System.Collections;

public class player1Movement : MonoBehaviour {
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform pos4;
	public Transform pos5;
	//string spot;
	string[] moves = new string[3];

	bool p1Move = false; //set false so have to activate it to make usable
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
	}
	
	// Update is called once per frame
	void Update () {
		CheckGrid ();
	}

	void CheckGrid(){
		if (Input.GetKey (KeyCode.A)) {
			p1Move = true;
		}

		if ((p1Move == true) && (Input.GetKeyDown (KeyCode.Tab)) && (p3 == false) && (p4 == false) && (p5 == false)) {
			transform.position = pos1.position;
			p1 = true;
			p2 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1Move = false;
			//spot = "a";
			//moves[0] = "a";
			//Debug.Log ("array 1 " + moves[0]);
		}
		if ((p1Move == true) && (Input.GetKeyDown (KeyCode.Q)) && (p4 == false) && (p5 == false)) {
			transform.position = pos2.position;
			p2 = true;
			p1 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1Move = false;
		}
		if ((p1Move == true) && (Input.GetKeyDown (KeyCode.W)) && (p1 == false) && (p5 == false)){
			transform.position = pos3.position;
			p3 = true;
			p1 = false;
			p2 = false;
			p4 = false;
			p5 = false;
			p1Move = false;
		}
		if ((p1Move == true) && (Input.GetKeyDown (KeyCode.E)) && (p1 == false) && (p2 == false)){
			transform.position = pos4.position;
			p4 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p5 = false;
		}
		if ((p1Move == true) && (Input.GetKeyDown (KeyCode.R)) && (p1 == false) && (p2 == false) && (p3 == false)){
			transform.position = pos5.position;
			p5 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p4 = false;
			p1Move = false;
		}
	}


}
