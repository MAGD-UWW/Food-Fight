using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public int playerTwoHealth { get; set; }
	public int playerTwoMaxHalth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }
	//Add any variables you can think of let me know


	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
	}
}
