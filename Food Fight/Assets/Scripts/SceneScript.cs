using UnityEngine;
using System.Collections;

public class SceneScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;

	void Start () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
	}
	

	void Update () {
		if(player1.playerOneHealth <= 0) {
			Application.LoadLevel ("EndP2Wins");
		}
		else if(player2.playerTwoHealth <= 0) {
			Application.LoadLevel ("EndP1Wins");
		}
	}
}
