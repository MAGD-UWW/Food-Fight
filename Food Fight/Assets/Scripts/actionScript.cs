using UnityEngine;
using System.Collections;

public class actionScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;

	bool p1throw = false;
	bool p1move = false;
	//bools for different movement positions
	bool p1 = false;
	bool p2 = false;
	bool p3 = false;
	bool p4 = false;
	bool p5 = false;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Actions(){
		pActions.playerOneChoices[player1.playerOneMaxActionPoints];
		// inputs for throwing
		if(Input.GetKey(KeyCode.D)){
			pActions.playerOneChoices[player1.playerOneActionPoints] = playerActions.move;
			p1throw = true;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.Tab))){
			pActions.playerOneChoices[player1.playerOneActionPoints].y = buttonTab;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.Q))){
			pActions.playerOneChoices[player1.playerOneActionPoints].y = buttonQ;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.W))){
			pActions.playerOneChoices[player1.playerOneActionPoints].y = buttonW;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.E))){
			pActions.playerOneChoices[player1.playerOneActionPoints].y = buttonE;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.R))){
			pActions.playerOneChoices[player1.playerOneActionPoints].y = buttonR;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		// inputs for moving
		if(Input.GetKey (KeyCode.A)){
			p1move = true;
		}
		if ((p1move == true) && (Input.GetKeyDown (KeyCode.Tab)) && (p3 == false) && (p4 == false) && (p5 == false)) {
			p1 = true;
			p2 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1move = false;
		}
		if ((p1move == true) && (Input.GetKeyDown (KeyCode.Q)) && (p4 == false) && (p5 == false)) { 
			p2 = true;
			p1 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1move = false;
		}
		if ((p1move == true)&&(Input.GetKeyDown (KeyCode.W)) && (p1 == false) && (p5 == false)){ 
			p3 = true;
			p1 = false;
			p2 = false;
			p4 = false;
			p5 = false;
			p1move = false;
		}
		if ((p1move == true) &&(Input.GetKeyDown (KeyCode.E)) && (p1 == false) && (p2 == false)){ 
			p4 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p5 = false;
			p1move = false;
		}
		if ((p1move == true) &&(Input.GetKeyDown (KeyCode.R)) && (p1 == false) && (p2 == false) && (p3 == false)){ 
			p5 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p4 = false;
			p1move = false;
		}

	}
}
