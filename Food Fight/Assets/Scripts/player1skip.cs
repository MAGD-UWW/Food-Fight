using UnityEngine;
using System.Collections;

public class player1skip : MonoBehaviour {
	public int playerOneSkip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//just replace the playerOneSkip with 1 spot in the action manager to make this 
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			playerOneSkip = 1;
			Debug.Log ("Player 1 skipped");
		}
	}
}
