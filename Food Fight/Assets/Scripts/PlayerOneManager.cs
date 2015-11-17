using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}

	//Declare PlayerOneVariables

	public void Startup() {
		Debug.Log ("Player One Manager has started");
		status = ManagerStatus.Started;
	}
}
