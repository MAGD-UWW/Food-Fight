using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}
	public int playerOneHealth { get; set; }
	public int playerOneMaxHalth { get; set; }
	public int playerOneFoodCount { get; set; }
	public int playerOneMaxFoodCount { get; set; }
	public int playerOneActionPoints { get; set; }
	//Add any variables you can think of let me know

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
	}
}
