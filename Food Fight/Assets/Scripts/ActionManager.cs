using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public void Startup () {
		Debug.Log ("Action Manager has started up");
		status = ManagerStatus.Started;
	}

	void Update () {
	
	}
}
