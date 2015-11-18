using UnityEngine;
using System.Collections;

public class PlayerOneManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}
	public int playerOneHealth { get; set; }
	public int playerOneMaxHealth { get; set; }
	public int playerOneFoodCount { get; set; }
	public int playerOneMaxFoodCount { get; set; }
	public int playerOneActionPoints { get; set; }
	//Add any variables you can think of let me know

	int carrying;
	GameObject food;

	public void Startup() {
		Debug.Log ("Player One Manager has started");
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
		if (Input.GetKeyDown ("l")) {
			carrying = carrying + 1;
			Debug.Log ("Player 1:");
			Debug.Log (carrying);
		}
	}
}
