using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerOne { get; set; }
	public int playerOneHealth { get; set; }
	public int playerOneMaxHealth { get; set; }
	public int playerOneFoodCount { get; set; }
	public int playerOneMaxFoodCount { get; set; }
	public int playerOneActionPoints { get; set; }
<<<<<<< HEAD
	//Add any variables you can think of let me know
	//public int playerTwoSkip { get; set; }

	//Anson what the player is picking up
	//GameObject food;
=======
	public int playerOneTotalActionPoints { get; set; }
>>>>>>> refs/remotes/origin/master

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
		playerOneTotalActionPoints = 3; //Sets total action points to 3
	}
	
	void Update () {	

	}

}
