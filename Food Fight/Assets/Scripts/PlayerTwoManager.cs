using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
	public int playerTwoHealth { get; set; }
	public int playerTwoMaxHealth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }
	//Add any variables you can think of let me know

	int carrying;
	GameObject food;

	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
	}

	void Start () {
		food = GameObject.FindWithTag ("food");
		
	}

	void Update () {
		
		if (carrying == 3) {
			carry (food);
		} else {
			pickup ();
		}
	}
	
	void carry(GameObject o){
		
	}
	
	void pickup(){
		if (Input.GetKeyDown ("d")) {
			carrying = carrying + 1;
			Debug.Log ("Player 2:");
			Debug.Log (carrying);
		}
	}
}
