using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public int playerTwoHealth { get; private set; }
	public int playerTwoMaxHalth { get; private set; }
	public int playerTwoFoodCount { get; private set; }
	public int playerTwoMaxFoodCount { get; private set; }
	public int playerTwoActionPoints { get; private set; }


	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
	}
}
