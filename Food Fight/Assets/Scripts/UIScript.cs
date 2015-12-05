using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {
	public float timerCount = 60;
	public Text timer;
	public GameObject choiceUI;
	public PlayerOneManager player1;
	public PlayerTwoManager player2;

	void Start () {
		choiceUI = GameObject.Find ("Canvas");
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
	}
	
	// Update is called once per frame
	/*************************************
	 * 	 Name: Eric Olson                *
	 * 	 Script: Working with Timer UI   * 
	 * 	 Date: 12/5/2015                 * 
	 * 	 Time: 2:36 A.M ... sooo sleepy  *
	 *                                   *
	 * 	 Description: Trying to regulate *
	 * 	 timer/UI based on actionpoints  *
	 *                                   *
     *************************************/
	void Update () {
		if(player1.playerOneActionPoints < 3 && player2.playerTwoActionPoints < 3) {
			choiceUI.SetActive (true);
			Clock ();
		}
		else {
			//choiceUI.SetActive (false);
			Debug.Log ("Turning Off UI");
			timerCount = 0;
		}
	}
	void Clock() {
		timerCount-=Time.deltaTime;
		timer.text = timerCount.ToString ();
	}
}
