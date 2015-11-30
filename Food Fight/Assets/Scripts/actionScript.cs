using UnityEngine;
using System.Collections;

public class actionScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager playerActions;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find("Manager").GetComponent<PlayerTwoManager>();
		playerActions = GameObject.Find ("Manager").GetComponent<ActionManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Actions(){
		playerActions.playerOneChoices[player1.playerOneActionPoints];
	}
}
