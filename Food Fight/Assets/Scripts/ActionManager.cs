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

	public void Startup () {
		//Enumerators
		playerActions playerOneActions;
		playerActions playerTwoActions;
		//playerOneActions = playerActions.move;
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		//Figure out how to use Enumerators as Index's for Arrays -Eric Olson 11/26/15
		playerOneChoices = new Vector2[player1.playerOneActionPoints];
		playerTwoChoices = new Vector2[player2.playerTwoActionPoints]; //Changed from Total Action Points to ActionPoints 11/26/15 Eric Olson
		/**
			PLAYER GRID OR PLAYER ACTIONS?  SHOULD GRID GO IN P1Manager / P2Manager? Reference P1Movement and P2Movement? - Eric Olson 11/26/15
			**Many ways of going about this
			**Grid selection THEN action, (x,y) MOVE or (x,y) THROW or (x,y) GRAB etc.
		playerOneChoices[0]( playerActions, playerGrid); //Player1 first choice
		playerOneChoices[1]( playerActions, playerGrid); //Player1 second choice
		playerOneChoices[2]( playerActions, playerGrid); //Player1 third choice
		playerTwoChoices[0]( playerActions, playerGrid); //Player2 first choice
		playerTwoChoices[1]( playerActions, playerGrid); //Player2 second choice
		playerTwoChoices[2]( playerActions, playerGrid); //Player2 third choice
		**/
	}


	void Update () {
		//if(Input.anyKey E)
			//playerOneChoices[player1.playerOneActionPoints].x = playerActions.move;
			//player1.playerOneActionPoints++;

		//Updates and "prints out" the choices in order

	
	}
}
