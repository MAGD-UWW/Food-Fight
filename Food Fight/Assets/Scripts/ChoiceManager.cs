using UnityEngine;
using System.Collections;

public class ChoiceManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}

	// this is Nick's awesome edit!
	// this is eric's cooler edit!
	// this is Christian's OK edit....


	//Declare Choice variables

	public void Startup() {
		Debug.Log ("Choice Manager has started");
		status = ManagerStatus.Started;
	}
}
