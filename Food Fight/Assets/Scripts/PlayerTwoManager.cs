using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }

	//Declare Player Two variables

	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
	}
}
