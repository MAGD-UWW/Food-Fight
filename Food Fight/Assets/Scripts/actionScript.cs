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
		//ACTION SELECTION
		if(Input.GetKey(KeyCode.D)){
			pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.toss;
			p1throw = true;
		}
		//GRID SELECTION SPOT
		if((p1throw == true) && (Input.GetKey(KeyCode.Tab))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.Q))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonQ;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.W))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonW;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.E))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonE;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.R))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonR;
			p1throw = false;
			player1.playerOneActionPoints ++;
		}
		// ACTION SELCETION
		if(Input.GetKey (KeyCode.A)){
			pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.move;
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
