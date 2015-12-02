using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExecutionScript : MonoBehaviour {
	public Transform playerOneSprite;
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform pos4;
	public Transform pos5;
	public Transform pos6;
	public Transform pos7;
	public Transform pos8;
	public Transform pos9;
	public Transform pos10;
	public GameObject food;
	public Transform foodMove;
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;
	public int counter; //Align int counter with UI timer

	void Start() {
		foodMove = GameObject.FindWithTag ("food").transform;
		playerOneSprite = GameObject.FindGameObjectWithTag("player1").transform;
		//pos1 - pos5 = player one grid left to right
		pos1 = GameObject.FindGameObjectWithTag ("position1").transform;
		pos2 = GameObject.FindGameObjectWithTag ("position2").transform;
		pos3 = GameObject.FindGameObjectWithTag ("position3").transform;
		pos4 = GameObject.FindGameObjectWithTag ("position4").transform;
		pos5 = GameObject.FindGameObjectWithTag ("position5").transform;
		//pos6 - pos10 = player two grid left to right
		pos6 = GameObject.FindGameObjectWithTag ("position6").transform;
		pos7 = GameObject.FindGameObjectWithTag ("position7").transform;
		pos8 = GameObject.FindGameObjectWithTag ("position8").transform;
		pos9 = GameObject.FindGameObjectWithTag ("position9").transform;
		pos10 = GameObject.FindGameObjectWithTag ("position10").transform;
		//Add text for UI counter to equal the int counter
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager>();
	}

	void Update() {
		if(counter == 0) { //Fix counter to align with UI timer
			for(int i=0; i<player1.playerOneMaxActionPoints; i++) {
				//If the index for playerOnes action points was assigned to MOVE
				if(pActions.playerOneActions[player1.playerOneMaxActionPoints] == ActionManager.playerActions.move) {
					playerOneMove ();
				}
				//If the index for playerOnes action points was assigned to TOSS
				if(pActions.playerOneActions[player1.playerOneMaxActionPoints] == ActionManager.playerActions.toss) {
					playerOneToss ();
				}
				//If the index for playerOnes action points was assigned to GRAB
				if(pActions.playerOneActions[player1.playerOneMaxActionPoints] == ActionManager.playerActions.grab) {
					playerOneGrab ();
				}
				//If the index for playerOnes action points was assigned to SKIP
				if(pActions.playerOneActions[player1.playerOneMaxActionPoints] == ActionManager.playerActions.skip) {
					Debug.Log ("Player One Decided to skip!");
				}
			}
		}
	}
	void playerOneMove() {
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonTab) {
			playerOneSprite.position = pos1.position; //[X][][][][]
			Debug.Log ("Player One is moving to it's pos1");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonQ) {
			playerOneSprite.position = pos2.position; //[][X][][][]
			Debug.Log ("Player One is moving to it's pos2");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonW) {
			playerOneSprite.position = pos3.position; //[][][X][][]
			Debug.Log ("Player One is moving to it's pos3");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonE) {
			playerOneSprite.position = pos4.position; //[][][][X][]
			Debug.Log ("Player One is moving to it's pos4");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonR) {
			playerOneSprite.position = pos5.position; //[][][][][X]
			Debug.Log ("Player One is moving to it's pos5");
		}
	}
	void playerOneGrab() {
		player1.playerOneFoodCount++;
	}
	void playerOneToss() {
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonTab) {
			//Instantiate Food from Player1 to pos6.position
			Instantiate(food, playerOneSprite.position, Quaternion.identity);
			foodMove.transform.Translate(pos6.position);
			player1.playerOneFoodCount--;
			Debug.Log ("Player One is throwing at player2 pos6");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonQ) {
			//Instantiate Food from Player1 to pos6.position
			Instantiate(food, playerOneSprite.position, Quaternion.identity);
			foodMove.transform.Translate (pos7.position);
			player1.playerOneFoodCount--;
			Debug.Log ("Player One is throwing at player2 pos7");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonW) {
			//Instantiate Food from Player1 to pos6.position
			Instantiate(food, playerOneSprite.position, Quaternion.identity);
			foodMove.transform.Translate (pos8.position);
			player1.playerOneFoodCount--;
			Debug.Log ("Player One is throwing at player2 pos8");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonE) {
			//Instantiate Food from Player1 to pos6.position
			Instantiate(food, playerOneSprite.position, Quaternion.identity);
			foodMove.transform.Translate (pos9.position);
			player1.playerOneFoodCount--;
			Debug.Log ("Player One is throwing at player2 pos9");
		}
		if(pActions.player1Grid[player1.playerOneMaxActionPoints] == ActionManager.playerOneGrid.buttonR) {
			//Instantiate Food from Player1 to pos6.position
			Instantiate(food, playerOneSprite.position, Quaternion.identity);
			foodMove.transform.Translate (pos10.position);
			player1.playerOneFoodCount--;
			Debug.Log ("Player One is throwing at player2 pos10");
		}
	}
}
