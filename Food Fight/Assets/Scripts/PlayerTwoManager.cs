﻿using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerTwo { get; set; }
	public int playerTwoHealth { get; set; }
	//Anson fixed spelling
	public int playerTwoMaxHealth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }
	//Add any variables you can think of let me know
	//public int playerTwoSkip { get; set; }

	//Anson what the player is picking up
	GameObject food;

	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
		//Anson need to reference the food 
		//food = GameObject.FindWithTag ("food"); *Uncomment When food is added to the main scene - Eric 11/19/2015
	}

	void Update () {	
		//Anson When the food count reaches 3 they can pickup no more
		if (playerTwoFoodCount == 3) {
			//carry (food); *Uncomment When food is added to the main scene - Eric 11/19/2015
		} else {
			pickup ();
		}
	}

	//Anson this is Player 2 max I think....
	void carry(GameObject o){
		
	}

	//Anson this is player 2 pressing L to add food
	void pickup(){
		if (Input.GetKeyDown ("l")) {
			playerTwoFoodCount = playerTwoFoodCount + 1;
			Debug.Log ("Player 2:");
			Debug.Log (playerTwoFoodCount);
		}
	}
}
