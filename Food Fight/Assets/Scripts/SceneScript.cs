using UnityEngine;
using System.Collections;

public class SceneScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public UIScript uiScript;

	void Start () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		uiScript = GameObject.Find ("UIScript").GetComponent<UIScript>();
	}
	

	void Update () {
	if(uiScript.timerCount <= -6.7 && uiScript.timerCount >= -6.9) { 
		if(player1.playerOneHealth <= 0 && player2.playerTwoHealth <= 0) {
			player1.playerOneHealth = 1;
			player2.playerTwoHealth = 1;
		}
		else if(player1.playerOneHealth <= 0) {
			Application.LoadLevel ("EndP2Wins");
		}
		else if(player2.playerTwoHealth <= 0) {
			Application.LoadLevel ("EndP1Wins");
		}
	 }
	}
}
