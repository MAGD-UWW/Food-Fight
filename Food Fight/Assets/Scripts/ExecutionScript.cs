using UnityEngine;
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
	public GameObject food2;
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;
	public UIScript uiScript;
	//PLAYER1TOSS BOOLS
	public bool pos6Toss = false;
	public bool pos7Toss = false;
	public bool pos8Toss = false;
	public bool pos9Toss = false;
	public bool pos10Toss = false;
	//PLAYER2TOSS BOOLS
	public bool pos1Toss = false;
	public bool pos2Toss = false;
	public bool pos3Toss = false;
	public bool pos4Toss = false;
	public bool pos5Toss = false;


	void Start() {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager>();
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
		uiScript = GameObject.Find ("UIScript").GetComponent<UIScript>();
		Debug.Log ("Player1 Action Points: " + player1.playerOneActionPoints);
		Debug.Log ("Player2 Action Points: " + player2.playerTwoActionPoints);
	}
	void Update() {
		skipCheck();
		executeMove();
	}
	void skipCheck() {
		if(uiScript.timerCount <= 0){
			if(player1.playerOneActionPoints < 3){
				for(;player1.playerOneActionPoints < 3;){
					pActions.playerOneActions[player1.playerOneActionPoints] = ActionManager.playerActions.skip;
					player1.playerOneActionPoints++;
				}
			}
			if(player2.playerTwoActionPoints < 3){
				for(;player2.playerTwoActionPoints < 3;){
					pActions.playerTwoActions[player2.playerTwoActionPoints] = ActionManager.playerActions.skip;
					player2.playerTwoActionPoints++;
				}
			}
		}
	}
	  
	void executeMove(){
		if(uiScript.timerCount <= 0){
			for(int i =0; i<player1.playerOneMaxActionPoints;) {
				//If the index for playerOnes action points was assigned to MOVE
				if(pActions.playerOneActions[i] == ActionManager.playerActions.move) {
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonTab) {
						playerOneSprite.position = pos1.position; //[X][][][][]
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is moving to pos1");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonQ) {
						playerOneSprite.position = pos2.position; //[][X][][][]
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is moving to pos2");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonW) {
						playerOneSprite.position = pos3.position; //[][][X][][]
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is moving to pos3");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonE) {
						playerOneSprite.position = pos4.position; //[][][][X][]
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is moving to it's pos4");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonR) {
						playerOneSprite.position = pos5.position; //[][][][][X]
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is moving to it's pos5");
						if(i == 3) {
							break;
						}
					}
				}
				//If the index for playerOnes action points was assigned to TOSS
				if(pActions.playerOneActions[i] == ActionManager.playerActions.toss) {
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonTab) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food2, playerOneSprite.position, Quaternion.identity);
						pos6Toss = true;
						player1.playerOneFoodCount--;
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is throwing at player2 pos6");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonQ) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food2, playerOneSprite.position, Quaternion.identity);
						pos7Toss = true;
						player1.playerOneFoodCount--;
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is throwing at player2 pos7");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonW) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food2, playerOneSprite.position, Quaternion.identity);
						pos8Toss = true;
						player1.playerOneFoodCount--;
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is throwing at player2 pos8");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonE) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food2, playerOneSprite.position, Quaternion.identity);
						pos9Toss = true;
						player1.playerOneFoodCount--;
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is throwing at player2 pos9");
						if(i == 3) {
							break;
						}
					}
					if(pActions.player1Grid[i] == ActionManager.playerOneGrid.buttonR) {
						//Instantiate Food from Player1 to pos6.position
						Instantiate(food2, playerOneSprite.position, Quaternion.identity);
						pos10Toss = true;
						player1.playerOneFoodCount--;
						player1.playerOneActionPoints--;
						i++;
						Debug.Log ("Player One is throwing at player2 pos10");
						if(i == 3) {
							break;
						}
					}
				}
				//If the index for playerOnes action points was assigned to GRAB
				if(pActions.playerOneActions[i] == ActionManager.playerActions.grab) {
					player1.playerOneFoodCount++;
					player1.playerOneActionPoints--;
					i++;
					Debug.Log ("Player One Grabbed Food");
					if(i == 3) {
						break;
					}
				}
				//If the index for playerOnes action points was assigned to SKIP
				if(pActions.playerOneActions[i] == ActionManager.playerActions.skip) {
					player1.playerOneActionPoints--;
					i++;
					Debug.Log ("Player One Decided to skip!");
					if(i == 3) {
						break;
					}
				}
			}
			
			
			
			
			
			
			
			
			
			
			for(int j = 0; j <player2.playerTwoMaxActionPoints;) {
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.move) {
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonI) {
						playerTwoSprite.position = pos6.position;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player Two is moving to pos6");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonO) {
						playerTwoSprite.position = pos7.position;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player Two is moving to pos7");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonP) {
						playerTwoSprite.position = pos8.position;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player Two is moving to pos8");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonLS) {
						playerTwoSprite.position = pos9.position;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player Two is moving to pos9");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonRS) {
						playerTwoSprite.position = pos10.position;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player Two is moving to pos10");
						if(j == 3) {
							break;
						}
					}
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.toss) {
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonI) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						pos1Toss = true;
						player2.playerTwoFoodCount--;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos1");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonO) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						pos2Toss = true;
						player2.playerTwoFoodCount--;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos2");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonP) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						pos3Toss = true;
						player2.playerTwoFoodCount--;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos3");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonLS) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						pos4Toss = true;
						player2.playerTwoFoodCount--;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos4");
						if(j == 3) {
							break;
						}
					}
					if(pActions.player2Grid[j] == ActionManager.playerTwoGrid.buttonRS) {
						Instantiate(food, playerTwoSprite.position, Quaternion.identity);
						pos5Toss = true;
						player2.playerTwoFoodCount--;
						player2.playerTwoActionPoints--;
						j++;
						Debug.Log ("Player two is throwing at player1 pos5");
						if(j == 3) {
							break;
						}
					}
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.grab) {
					player2.playerTwoFoodCount++;
					player2.playerTwoActionPoints--;
					j++;
					Debug.Log ("Player Two Grabbed Food");
					if(j == 3) {
						break;
					}
				}
				if(pActions.playerTwoActions[j] == ActionManager.playerActions.skip) {
					player2.playerTwoActionPoints--;
					j++;
					Debug.Log ("Player Two Decided to skip!");
					if(j == 3) {
						break;
					}
				}
			}
		}
	  }

}
