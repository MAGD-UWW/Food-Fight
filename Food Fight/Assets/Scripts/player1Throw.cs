using UnityEngine;
using System.Collections;

public class player1Throw : MonoBehaviour {
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform pos4;
	public Transform pos5;

	bool p1Throw = false;

	// Use this for initialization
	void Start () {
		pos1 = GameObject.FindGameObjectWithTag ("position1").transform;
		pos2 = GameObject.FindGameObjectWithTag ("position2").transform;
		pos3 = GameObject.FindGameObjectWithTag ("position3").transform;
		pos4 = GameObject.FindGameObjectWithTag ("position4").transform;
		pos5 = GameObject.FindGameObjectWithTag ("position5").transform;
	}
	
	// Update is called once per frame
	void Update () {
		ThrowAtGrid ();
	}

	void ThrowAtGrid(){
		if (Input.GetKey (KeyCode.D)) {
			p1Throw = true;
		}

		if ((p1Throw == true) && (Input.GetKey (KeyCode.Tab))){
			Debug.Log("throw at position 1");
			p1Throw = false;
			// food.position = pos1.position;
		}

		if ((p1Throw == true) && (Input.GetKey (KeyCode.Q))){
			Debug.Log("throw at position 2");
			// food.position = pos2.position;
			p1Throw = false;
		}

		if ((p1Throw == true) && (Input.GetKey (KeyCode.W))){
			Debug.Log("throw at position 3");
			p1Throw = false;
			// food.position = pos1.position;
		}

		if ((p1Throw == true) && (Input.GetKey (KeyCode.E))){
			Debug.Log("throw at position 4");
			p1Throw = false;
			// food.position = pos1.position;
		}
		if ((p1Throw == true) && (Input.GetKey (KeyCode.R))){
			Debug.Log("throw at position 5");
			p1Throw = false;
			// food.position = pos1.position;
		}
	}
}
