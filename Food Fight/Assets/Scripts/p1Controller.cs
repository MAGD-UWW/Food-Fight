using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	float carrying;
	GameObject food;
	
	// Use this for initialization
	void Start () {
		food = GameObject.FindWithTag ("food");

	}
	
	// Update is called once per frame
	void Update () {

		if (carrying == 3 ) {
			carry (food);
		} else {
			pickup ();
		}
		//move up
		//value = Input.GetKey ("a");
		//move down
		//value = Input.GetKey ("s");
		//grab food
		//value = Input.GetKey ("d");
		//throw grid space 1
		//value = Input.GetKey ("q");
		//throw grid space 2
		//value = Input.GetKey ("w");
		//throw grid space 3
		//value = Input.GetKey ("e");
		//throw grid space 4
		//value = Input.GetKey ("r");
		//throw grid space 5
		//value = Input.GetKey ("t");
	}

	void carry(GameObject o){
		
		
	}
	void pickup(){
		if (Input.GetKeyDown ("w")) {
			carrying = carrying + 1;
			Debug.Log ("Player 1:");
			Debug.Log (carrying);
		}
	}
}
