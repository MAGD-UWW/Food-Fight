using UnityEngine;
using System.Collections;

public class SecretScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public GameObject bouldar;
	public GameObject bouldarMode; //Put text on the table, 
	public AudioSource foodSound;
	public AudioClip foodClip;
	public AudioSource bouldarSound;
	public AudioClip bouldClip;

	void Start() {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.PageUp)) {
			foodSound.stop();
			bouldarSound.play();
			bouldarMode.SetActive(true);
			Instantiate(bouldar, player1.playerOneSprite.position, Quaternion.Identity);
			player1.playerOneHealth -= 75;
		}
		if(Input.GetKeyDown (KeyCode.PageDown)) {
			foodSound.stop();
			bouldarSound.play();
			bouldarMode.SetActive(true);
			Instantiate(bouldar, player2.playerTwoSprite.position, Quaternion.Identity);
			player2.playerTwoHealth -= 75;
		}
	}
}
