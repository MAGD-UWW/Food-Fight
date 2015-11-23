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
	public enum playerActions{ move, toss, grab };
	public enum playerOneGrid { buttonTab, buttonQ, buttonW, buttonE, buttonR };
	public enum playerTwoGrid { buttonI, buttonO, buttonP, buttonLS, button5RS }; //LS = left square [ || RS = right square ]

	public void Startup () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		playerOneChoices = new Vector2[player1.playerOneActionPoints];
		playerTwoChoices = new Vector2[player2.playerTwoTotalActionPoints];
		//X = move, throw, grab(3 buttons) || y = Grid movement(5 buttons)
		/**
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

	
	}
}
