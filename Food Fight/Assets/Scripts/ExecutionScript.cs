using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExecutionScript : MonoBehaviour {
	public Transform playerOneSprite;
	public Transform playerTwoSprite;
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform pos4;
	public Transform pos5;
	public Transform pos6;
	public Transform pos7;
	public Transform pos8;
	public Transform pos9;
	public Transform pos10;
	public GameObject food;
	public Transform foodMove;
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;
	public float timerCount;
	public Text timer;

	void Start() {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager>();
		foodMove = GameObject.FindGameObjectWithTag ("food").transform;
		playerOneSprite = GameObject.FindGameObjectWithTag("player1").transform;
		playerTwoSprite = GameObject.FindGameObjectWithTag ("player2").transform;
		//pos1 - pos5 = player one grid left to right
		pos1 = GameObject.FindGameObjectWithTag ("position1").transform;
		pos2 = GameObject.FindGameObjectWithTag ("position2").transform;
		pos3 = GameObject.FindGameObjectWithTag ("position3").transform;
		pos4 = GameObject.FindGameObjectWithTag ("position4").transform;
		pos5 = GameObject.FindGameObjectWithTag ("position5").transform;
		//pos6 - pos10 = player two grid left to right
		pos6 = GameObject.FindGameObjectWithTag ("position6").transform;
		pos7 = GameObject.FindGameObjectWithTag ("position7").transform;
		pos8 = GameObject.FindGameObjectWithTag ("position8").transform;
		pos9 = GameObject.FindGameObjectWithTag ("position9").transform;
		pos10 = GameObject.FindGameObjectWithTag ("position10").transform;
		Debug.Log ("Player1 Action Points: " + player1.playerOneActionPoints);
	}

	void Update() {
		if(player1.playerOneActionPoints == 3 && player2.playerTwoActionPoints == 3) {
			for(int i=0; i<player1.playerOneMaxActionPoints;) {
				//If the index for playerOnes action points was assigned to MOVE
				if(pActions.playerOneActions[i] == ActionManager.playerActions.move) {
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonTab) {
						playerOneSprite.position = pos1.position; //[X][][][][]
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is moving to pos1");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonQ) {
						playerOneSprite.position = pos2.position; //[][X][][][]
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is moving to pos2");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonW) {
						playerOneSprite.position = pos3.position; //[][][X][][]
						i++;
						Debug.Log ("Player1 i: " + i);;
						Debug.Log ("Player One is moving to pos3");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonE) {
						playerOneSprite.position = pos4.position; //[][][][X][]
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is moving to it's pos4");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonR) {
						playerOneSprite.position = pos5.position; //[][][][][X]
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is moving to it's pos5");
					}
				}
				//If the index for playerOnes action points was assigned to TOSS
				if(pActions.playerOneActions[i] == ActionManager.playerActions.toss) {
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonTab) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food, playerOneSprite.position, Quaternion.identity);
						foodMove.transform.Translate(pos6.position);
						player1.playerOneFoodCount--;
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is throwing at player2 pos6");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonQ) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food, playerOneSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos7.position);
						player1.playerOneFoodCount--;
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is throwing at player2 pos7");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonW) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food, playerOneSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos8.position);
						player1.playerOneFoodCount--;
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is throwing at player2 pos8");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonE) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food, playerOneSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos9.position);
						player1.playerOneFoodCount--;
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is throwing at player2 pos9");
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonR) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food, playerOneSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos10.position);
						player1.playerOneFoodCount--;
						i++;
						Debug.Log ("Player1 i: " + i);
						Debug.Log ("Player One is throwing at player2 pos10");
					}
				}
				//If the index for playerOnes action points was assigned to GRAB
				if(pActions.playerOneActions[i] == ActionManager.playerActions.grab) {
					player1.playerOneFoodCount++;
					i++;
					Debug.Log ("Player1 i: " + i);
					Debug.Log ("Player One Grabbed Food");
				}
				//If the index for playerOnes action points was assigned to SKIP
				if(pActions.playerOneActions[i] == ActionManager.playerActions.skip) {
					i++;
					Debug.Log ("Player1 i: " + i);
					Debug.Log ("Player One Decided to skip!");
				}
			}
			for(int j = 0; j <player2.playerTwoMaxActionPoints;) {
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.move) {
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonI) {
						playerTwoSprite.position = pos6.position;
						j++;
						Debug.Log ("Player Two is moving to pos6");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonO) {
						playerTwoSprite.position = pos7.position;
						j++;
						Debug.Log ("Player Two is moving to pos7");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonP) {
						playerTwoSprite.position = pos8.position;
						j++;
						Debug.Log ("Player Two is moving to pos8");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonLS) {
						playerTwoSprite.position = pos9.position;
						j++;
						Debug.Log ("Player Two is moving to pos9");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonRS) {
						playerTwoSprite.position = pos10.position;
						j++;
						Debug.Log ("Player Two is moving to pos10");
					}
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.toss) {
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonI) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos1.position);
						player2.playerTwoFoodCount--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos1");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonO) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos2.position);
						player2.playerTwoFoodCount--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos2");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonP) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos3.position);
						player2.playerTwoFoodCount--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos3");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonLS) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos4.position);
						player2.playerTwoFoodCount--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos4");
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonRS) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						foodMove.transform.Translate (pos5.position);
						player2.playerTwoFoodCount--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos5");
					}
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.grab) {
					player2.playerTwoFoodCount++;
					j++;
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.skip) {
					j++;
					Debug.Log ("Player Two Decided to skip!");
				}
			}
		}
		//Add text for UI counter to equal the int counter
		Clock();
	}
	void Clock() {
		timer.text = timerCount.ToString ();
		timerCount-=Time.deltaTime;
		if(timerCount == 0) {
			timerCount = 0;
		}
	}
}
