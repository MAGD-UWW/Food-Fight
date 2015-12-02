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
	public int playerTwoTotalActionPoints { get; set; }
	public int playerTwoMaxActionPoints { get; set; }



	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
		playerTwoActionPoints = 0;
		playerTwoMaxActionPoints = 3;
		playerTwoFoodCount = 0;
		playerTwoMaxFoodCount = 2;
		playerTwoMaxHealth = 100;
		playerTwoHealth = playerTwoMaxHealth;
	}

	void Update () {	

	}
}
