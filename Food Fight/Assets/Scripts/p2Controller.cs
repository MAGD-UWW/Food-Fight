using UnityEngine;
using System.Collections;

public class p2Controller : MonoBehaviour {

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
		//value = Input.GetKey ("up");
		//move down
		//value = Input.GetKey ("down");
		//grab food
		//value = Input.GetKey ("right shift");
		//throw grid space 1
		//value = Input.GetKey ("1");
		//throw grid space 2
		//value = Input.GetKey ("2");
		//throw grid space 3
		//value = Input.GetKey ("3");
		//throw grid space 4
		//value = Input.GetKey ("4");
		//throw grid space 5
		//value = Input.GetKey ("5");
	}
	void carry(GameObject o){


	}
	void pickup(){
		if (Input.GetKeyDown ("e")) {
			carrying = carrying + 1;
			Debug.Log ("Player 2:");
			Debug.Log (carrying);
		}
	}
}
