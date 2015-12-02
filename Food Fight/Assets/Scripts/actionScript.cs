using UnityEngine;
using System.Collections;

public class actionScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;

	bool p1throw = false;
	bool p1move = false;

	bool p2throw = false;
	bool p2move = false;
	//player1 movement positions
	bool p1 = false;
	bool p2 = false;
	bool p3 = false;
	bool p4 = false;
	bool p5 = false;

	//player2 movement positions
	bool p6 = false;
	bool p7 = false;
	bool p8 = false;
	bool p9 = false;
	bool p10 = false;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		Actions ();
	}

	void Actions(){
		//////////////////////PLAYER 1 ACTION AND GRID SELECTIONS////////////////////////////////
		//ACTION SELECTION (toss)
		if(Input.GetKey(KeyCode.D)){
			pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.toss;
			p1throw = true;
			Debug.Log ("player 1 picked toss");
		}
		//GRID SELECTION SPOT
		if((p1throw == true) && (Input.GetKey(KeyCode.Tab))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			p1throw = false;
			player1.playerOneActionPoints ++;
			Debug.Log ("p1 toss at position 6");
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.Q))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonQ;
			p1throw = false;
			player1.playerOneActionPoints ++;
			Debug.Log ("p1 toss at position 7");
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.W))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonW;
			p1throw = false;
			player1.playerOneActionPoints ++;
			Debug.Log ("p1 toss at position 8");
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.E))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonE;
			p1throw = false;
			player1.playerOneActionPoints ++;
			Debug.Log ("p1 toss at position 9");
		}
		if((p1throw == true) && (Input.GetKey(KeyCode.R))){
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonR;
			p1throw = false;
			player1.playerOneActionPoints ++;
			Debug.Log ("p1 toss at position 10");
		}
		// ACTION SELCETION (move)
		if(Input.GetKey (KeyCode.A)){
			pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.move;
			p1move = true;
			Debug.Log ("player 1 chose to move");
		}
		// GRID SELECTION SPOT
		if ((p1move == true) && (Input.GetKey (KeyCode.Tab)) && (p3 == false) && (p4 == false) && (p5 == false)) {
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			player1.playerOneActionPoints ++;

			p1 = true;
			p2 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1move = false;
			Debug.Log ("p1 move to position 1");
		}
		if ((p1move == true) && (Input.GetKey (KeyCode.Q)) && (p4 == false) && (p5 == false)) { 
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			player1.playerOneActionPoints ++;

			p2 = true;
			p1 = false;
			p3 = false;
			p4 = false;
			p5 = false;
			p1move = false;
			Debug.Log ("p1 move to position 2");
		}
		if ((p1move == true)&&(Input.GetKey (KeyCode.W)) && (p1 == false) && (p5 == false)){ 
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			player1.playerOneActionPoints ++;

			p3 = true;
			p1 = false;
			p2 = false;
			p4 = false;
			p5 = false;
			p1move = false;
			Debug.Log ("p1 move to position 3");
		}
		if ((p1move == true) &&(Input.GetKey (KeyCode.E)) && (p1 == false) && (p2 == false)){ 
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			player1.playerOneActionPoints ++;

			p4 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p5 = false;
			p1move = false;
			Debug.Log ("p1 move to position 4");
		}
		if ((p1move == true) &&(Input.GetKey (KeyCode.R)) && (p1 == false) && (p2 == false) && (p3 == false)){ 
			pActions.player1Grid[player1.playerOneActionPoints] = ActionManager.playerOneGrid.buttonTab;
			player1.playerOneActionPoints ++;

			p5 = true;
			p1 = false;
			p2 = false;
			p3 = false;
			p4 = false;
			p1move = false;
			Debug.Log ("p1 move to position 5");
		}

		// ACTION SELECTION (skip)
		if (Input.GetKey (KeyCode.LeftShift)) {
			pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.skip;
			player1.playerOneActionPoints ++;
			Debug.Log ("player 1 chose to skip");
		}

		// ACTION SELECTION (grab)
		if (Input.GetKey (KeyCode.S)) {
			if(player1.playerOneFoodCount < player1.playerOneMaxFoodCount){
				pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.grab;
				player1.playerOneActionPoints ++;
				Debug.Log ("player 1 picked up food");
			}else{
				Debug.Log ("Can't pick up more food");
			}
		}

		//////////////////////////////////PLAYER 2 ACTION AND GRID SELECTIONS///////////////////////////////////
		//ACTION SELECTION (toss)
		if(Input.GetKey (KeyCode.Semicolon)){
			pActions.playerTwoActions[player2.playerTwoActionPoints] = ActionManager.playerActions.toss;
			p2throw = true;
			Debug.Log ("player 2 chose to toss");
		}

		//GRID SELECTION SPOT
		if((p2throw == true) && (Input.GetKey(KeyCode.I))){
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonI;
			p2throw = false;
			player2.playerTwoActionPoints ++;
			Debug.Log ("p2 toss at position 1");
		}
		if((p2throw == true) && (Input.GetKey(KeyCode.O))){
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonO;
			p2throw = false;
			player2.playerTwoActionPoints ++;
			Debug.Log ("p2 toss at position 2");
		}
		if((p2throw == true) && (Input.GetKey(KeyCode.P))){
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonP;
			p2throw = false;
			player2.playerTwoActionPoints ++;
			Debug.Log ("p2 toss at position 3");
		}
		if((p2throw == true) && (Input.GetKey(KeyCode.LeftBracket))){
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonLS;
			p2throw = false;
			player2.playerTwoActionPoints ++;
			Debug.Log ("p2 toss at position 4");
		}
		if((p2throw == true) && (Input.GetKey(KeyCode.RightBracket))){
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonRS;
			p2throw = false;
			player2.playerTwoActionPoints ++;
			Debug.Log ("p2 toss at position 5");
		}
		// ACTION SELCETION (move)
		if(Input.GetKey (KeyCode.K)){
			pActions.playerTwoActions[player2.playerTwoActionPoints] = ActionManager.playerActions.move;
			p2move = true;
			Debug.Log ("player 2 chose to move");
		}
		// GRID SELECTION SPOT
		if ((p2move == true) && (Input.GetKey (KeyCode.I)) && (p8 == false) && (p9 == false) && (p10 == false)) {
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonI;
			player2.playerTwoActionPoints ++;
			
			p6 = true;
			p7 = false;
			p8 = false;
			p9 = false;
			p10 = false;
			p2move = false;
			Debug.Log ("p2 move to position 6");
		}
		if ((p2move == true) && (Input.GetKey (KeyCode.O)) && (p9 == false) && (p10 == false)) { 
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonO;
			player2.playerTwoActionPoints ++;
			
			p7 = true;
			p6 = false;
			p8 = false;
			p9 = false;
			p10 = false;
			p2move = false;
			Debug.Log ("p2 move to position 7");
		}
		if ((p2move == true)&&(Input.GetKey (KeyCode.P)) && (p6 == false) && (p10 == false)){ 
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonP;
			player2.playerTwoActionPoints ++;
			
			p8 = true;
			p6 = false;
			p7 = false;
			p9 = false;
			p10 = false;
			p2move = false;
			Debug.Log ("p2 move to position 8");
		}
		if ((p2move == true) &&(Input.GetKey (KeyCode.LeftBracket)) && (p6 == false) && (p7 == false)){ 
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonLS;
			player2.playerTwoActionPoints ++;
			
			p9 = true;
			p6 = false;
			p7 = false;
			p8 = false;
			p10 = false;
			p2move = false;
			Debug.Log ("p2 move to position 9");
		}
		if ((p2move == true) &&(Input.GetKey (KeyCode.RightBracket)) && (p6 == false) && (p7 == false) && (p8 == false)){ 
			pActions.player2Grid[player2.playerTwoActionPoints] = ActionManager.playerTwoGrid.buttonRS;
			player2.playerTwoActionPoints ++;
			
			p10 = true;
			p6 = false;
			p7 = false;
			p8 = false;
			p9 = false;
			p2move = false;
			Debug.Log ("p2 move to position 10");
		}
		// ACTION SELECTION (skip)
		if (Input.GetKey (KeyCode.RightShift)) {
			pActions.playerTwoActions[player2.playerTwoActionPoints] = ActionManager.playerActions.skip;
			player2.playerTwoActionPoints ++;
			Debug.Log ("player 2 chose to skip");
		}
		
		// ACTION SELECTION (grab)
		if (Input.GetKey (KeyCode.L)) {
			if(player2.playerTwoFoodCount < player2.playerTwoMaxFoodCount){
				pActions.playerTwoActions[player2.playerTwoActionPoints] = ActionManager.playerActions.grab;
				player2.playerTwoActionPoints ++;
				Debug.Log ("player 2 picked up more food");
			}else{
				Debug.Log ("Can't pick up more food");
			}
		}
	}
}