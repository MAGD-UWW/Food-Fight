using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerTwo { get; set; }
	public int playerTwoHealth { get; set; }
	public int playerTwoMaxHealth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }

	

	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
		playerTwoActionPoints = 0;
		playerTwoFoodCount = 0;
		playerTwoMaxHealth = 100;
		playerTwoHealth = playerTwoMaxHealth;
	}

	void Update () {	

	}
}
