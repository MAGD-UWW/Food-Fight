using UnityEngine;
using System.Collections;

public class player2skip : MonoBehaviour {
	public int playerTwoSkip;
	public GameObject used1;
	public GameObject used2;
	public GameObject used3;
	// Use this for initialization
	void Start () {
		used1.SetActive(false);
		used2.SetActive(false);
		used3.SetActive(false);
		//unused.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		//just replace the playerTwoSkip with 1 spot in the action manager to make this 
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			used1.SetActive(true);
			used2.SetActive(true);
			used3.SetActive(true);
			//unused.SetActive (false);
			playerTwoSkip = 1;
			Debug.Log ("Player 2 skipped" + playerTwoSkip);
		}

	}
}