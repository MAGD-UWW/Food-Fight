using UnityEngine;
using System.Collections;

public class SecretScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;

	void Start() {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.PageUp)) {
			player1.playerOneHealth = 0;
		}
		if(Input.GetKeyDown (KeyCode.PageDown)) {
			player2.playerTwoHealth = 0;
		}
	}
}
