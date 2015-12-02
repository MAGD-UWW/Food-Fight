using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerTwo { get; set; }
	public int playerTwoHealth { get; set; }
	public int playerTwoMaxHealth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }

	//Add any variables you can think of let me know
	//public int playerTwoSkip { get; set; }

	//Anson what the player is picking up
	GameObject food;

	public int playerTwoTotalActionPoints { get; set; }



	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
		playerTwoTotalActionPoints = 3; //Total action points for player2
	}

	void Update () {	

	}
}
