using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public GameObject playerOne { get; set; }
	public int playerOneHealth { get; set; }
	public int playerOneMaxHealth { get; set; }
	public int playerOneFoodCount { get; set; }
	public int playerOneActionPoints { get; set; }
	public int playerOneMaxActionPoints { get; set; }

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
		playerOneActionPoints = 0;
		playerOneMaxActionPoints = 3;
		playerOneFoodCount = 0;
		playerOneMaxHealth = 100;
		playerOneHealth = playerOneMaxHealth;
	}
	
	void Update () {	

	}

}
