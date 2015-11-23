﻿using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerOne { get; set; }
	public int playerOneHealth { get; set; }
	//Anson fixed spelling
	public int playerOneMaxHealth { get; set; }
	public int playerOneFoodCount { get; set; }
	public int playerOneMaxFoodCount { get; set; }
	public int playerOneActionPoints { get; set; }
	//Add any variables you can think of let me know
	//public int playerTwoSkip { get; set; }

	//Anson what the player is picking up
	//GameObject food;

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
		//Anson need to reference the food 
		//food = GameObject.FindWithTag ("food"); *Uncomment When food is added to the main scene - Eric 11/19/2015
	}
	
	void Update () {	
		//Anson When the food count reaches 3 they can pickup no more
		if (playerOneFoodCount == 3) {
			//carry (food); *Uncomment When food is added to the main scene - Eric 11/19/2015
		} else {
			pickup ();
		}
	}
	
	//Anson this is Player 2 max I think....
	void carry(GameObject o){
		
	}
	
	//Anson this is player 1 pressing D to add food
	void pickup(){
		if (Input.GetKeyDown ("d")) {
			playerOneFoodCount = playerOneFoodCount + 1;
			Debug.Log ("Player 1:");
			Debug.Log (playerOneFoodCount);
		}
	}
}
