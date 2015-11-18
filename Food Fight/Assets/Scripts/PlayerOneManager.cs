using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}
	public int playerOneHealth { get; private set; }
	public int playerOneMaxHalth { get; private set; }
	public int playerOneFoodCount { get; private set; }
	public int playerOneMaxFoodCount { get; private set; }
	public int playerOneActionPoints { get; private set; }

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
	}
}
