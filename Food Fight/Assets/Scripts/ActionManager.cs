using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ActionManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public Vector2[] playerOneChoices;
	public Vector2[] playerTwoChoices;
	//Organized the Enumerators 11/26/15 Eric Olson
	public enum playerActions{ //Actions the players move
		move = 1,
		toss = 2, 
		grab = 3, 
		skip = 4 
	};
	//Should I instead, make these "move" actions within the playerActions enumerator? - 11/26/15 Eric Olson
	public enum playerOneGrid { //Buttons player one uses 
		buttonTab = 5, 
		buttonQ = 6, 
		buttonW = 7, 
		buttonE = 8, 
		buttonR = 9 
	};



	//Should I instead, make these "move" actions within the playerActions enumerator? - 11/26/15 Eric Olson
	public enum playerTwoGrid { //Buttons player two uses
		buttonI = 10,
		buttonO = 11, 
		buttonP = 12, 
		buttonLS = 13, 
		buttonRS = 14 
	}; //LS = left square bracket || RS = right square bracket

	public void Startup () {
		//Enumerators
		playerActions playerOneActions;
		playerActions playerTwoActions;
		playerOneGrid player1Grid;
		playerTwoGrid player2Grid;
		//playerOneActions = playerActions.move;
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		//Figure out how to use Enumerators as Index's for Arrays -Eric Olson 11/26/15
		playerOneChoices = new Vector2[playerActions, playerOneGrid];
		playerTwoChoices = new Vector2[playerActions, playerTwoGrid]; //Changed from Total Action Points to ActionPoints 11/26/15 Eric Olson
	}


	void Update () {

	
	}
}
