using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ActionManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public playerActions[] playerOneActions;
	public playerActions[] playerTwoActions;
	public playerOneGrid[] player1Grid;
	public playerTwoGrid[] player2Grid;

	public enum playerActions{ //Actions the players move
		move,
		toss, 
		grab, 
		skip 
	};
	//Should I instead, make these "move" actions within the playerActions enumerator? - 11/26/15 Eric Olson
	public enum playerOneGrid { //Buttons player one uses 
		buttonTab,
		buttonQ, 
		buttonW, 
		buttonE, 
		buttonR 
	};



	//Should I instead, make these "move" actions within the playerActions enumerator? - 11/26/15 Eric Olson
	public enum playerTwoGrid { //Buttons player two uses
		buttonI,
		buttonO, 
		buttonP, 
		buttonLS, 
		buttonRS
	}; //LS = left square bracket || RS = right square bracket

	public void Startup() {
		Debug.Log ("Action Manager has started!");
		status = ManagerStatus.Started;
		player1 = gameObject.GetComponent<PlayerOneManager>();
		player2 = gameObject.GetComponent<PlayerTwoManager>();
		playerOneActions = new playerActions[player1.playerOneMaxActionPoints];
		playerTwoActions = new playerActions[player2.playerTwoMaxActionPoints];
		player1Grid = new playerOneGrid[player1.playerOneMaxActionPoints];
		player2Grid = new playerTwoGrid[player2.playerTwoMaxActionPoints];
	}


	void Update () {

	
	}
}
