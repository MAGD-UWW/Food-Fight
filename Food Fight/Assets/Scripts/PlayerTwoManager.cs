using UnityEngine;
using System.Collections;

public class PlayerTwoManager : MonoBehaviour, IGameManager {
	public ManagerStatus status { get; private set; }
<<<<<<< HEAD
<<<<<<< HEAD
	public int playerTwoHealth { get; set; }
	//Anson fixed spelling
	public int playerTwoMaxHealth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }
	//Add any variables you can think of let me know
=======
	public int playerTwoHealth { get; private set; }
	public int playerTwoMaxHalth { get; private set; }
	public int playerTwoFoodCount { get; private set; }
	public int playerTwoMaxFoodCount { get; private set; }
	public int playerTwoActionPoints { get; private set; }
>>>>>>> refs/remotes/origin/master
=======
	public int playerTwoHealth { get; set; }
	public int playerTwoMaxHalth { get; set; }
	public int playerTwoFoodCount { get; set; }
	public int playerTwoMaxFoodCount { get; set; }
	public int playerTwoActionPoints { get; set; }
>>>>>>> refs/remotes/origin/master

	//Anson what the player is picking up
	GameObject food;

	public void Startup() {
		Debug.Log ("Player Two Manager has started");
		status = ManagerStatus.Started;
		//Anson need to reference the food 
		food = GameObject.FindWithTag ("food");
	}

	void Update () {	
		//Anson When the food count reaches 3 they can pickup no more
		if (playerTwoFoodCount == 3) {
			carry (food);
		} else {
			pickup ();
		}
	}

	//Anson this is Player 2 max I think....
	void carry(GameObject o){
		
	}

	//Anson this is player 2 pressing L to add food
	void pickup(){
		if (Input.GetKeyDown ("l")) {
			playerTwoFoodCount = playerTwoFoodCount + 1;
			Debug.Log ("Player 2:");
			Debug.Log (playerTwoFoodCount);
		}
	}
}
