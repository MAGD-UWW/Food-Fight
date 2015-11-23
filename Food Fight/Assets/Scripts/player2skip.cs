using UnityEngine;
using System.Collections;

public class player2skip : MonoBehaviour {
	public int playerTwoSkip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//just replace the playerTwoSkip with 1 spot in the action manager to make this 
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			playerTwoSkip = 1;
			Debug.Log ("Player 2 skipped");
		}
	}
}