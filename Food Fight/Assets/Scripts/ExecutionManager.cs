using UnityEngine;
using System.Collections;

public class ExecutionManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }

	//Declare Execution Variables

	public void Startup() {
		Debug.Log ("Execution Manager has started");
		status = ManagerStatus.Started;
	}
}
