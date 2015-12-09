using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {
	public float timerCount;
	public Text timer;
	public GameObject choiceUI;
	public GameObject executionUI;
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public ActionManager pActions;
	public GameObject p1Choice1;
	public GameObject p1Choice2;
	public GameObject p1Choice3;
	public GameObject p1Choice1F;
	public GameObject p1Choice2F;
	public GameObject p1Choice3F;
	public GameObject p2Choice1;
	public GameObject p2Choice2;
	public GameObject p2Choice3;
	public GameObject p2Choice1F;
	public GameObject p2Choice2F;
	public GameObject p2Choice3F;


	void Start () {
		choiceUI = GameObject.Find ("ChoiceUI");
		executionUI = GameObject.Find ("ExecutionUI");
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		pActions = GameObject.Find ("Manager").GetComponent<ActionManager>();
		p1Choice1 = GameObject.Find ("p1Choice1");
		p1Choice2 = GameObject.Find ("p1Choice2");
		p1Choice3 = GameObject.Find ("p1Choice3");
		p1Choice1F = GameObject.Find ("p1Choice1F");
		p1Choice2F = GameObject.Find ("p1Choice2F");
		p1Choice3F = GameObject.Find ("p1Choice3F");
		p2Choice1 = GameObject.Find ("p2Choice1");
		p2Choice2 = GameObject.Find ("p2Choice2");
		p2Choice3 = GameObject.Find ("p2Choice3");
		p2Choice1F = GameObject.Find ("p2Choice1F");
		p2Choice2F = GameObject.Find ("p2Choice2F");
		p2Choice3F = GameObject.Find ("p2Choice3F");
	}

	void Update () {
		Clock ();
		//action points controlling UI 
		if(player1.playerOneActionPoints == 3 && player2.playerTwoActionPoints == 3 && timerCount > 10) {
			timerCount = 5;
			choiceUI.SetActive (true);
		}
		if(timerCount <= 0) {
			choiceUI.SetActive(false);
		}
		if(timerCount <=-15) {
			player1.playerOneActionPoints = 0;
			player2.playerTwoActionPoints = 0;
			timerCount = 35;
			choiceUI.SetActive(true);
		}
		player1Dots ();
		player2Dots ();
	}
	void Clock() {
		timerCount-=Time.deltaTime;
		timer.text = timerCount.ToString ("f1");
	}
	void player1Dots() {
		if(player1.playerOneActionPoints == 0) {
			p1Choice1.SetActive (true);
			p1Choice2.SetActive (true);
			p1Choice3.SetActive (true);
			p1Choice1F.SetActive(false);
			p1Choice2F.SetActive (false);
			p1Choice3F.SetActive (false);
		}
		if(player1.playerOneActionPoints == 1) {
			p1Choice1.SetActive (true);
			p1Choice2.SetActive (true);
			p1Choice3.SetActive (true);
			p1Choice1F.SetActive (true);
		}
		if(player1.playerOneActionPoints == 2) {
			p1Choice1.SetActive (true);
			p1Choice2.SetActive (true);
			p1Choice3.SetActive (true);
			p1Choice2F.SetActive(true);
		}
		if(player1.playerOneActionPoints == 3) {
			p1Choice1.SetActive (true);
			p1Choice2.SetActive (true);
			p1Choice3.SetActive (true);
			p1Choice3F.SetActive (true);
		}
		if(timerCount <= 0) {
			p1Choice1.SetActive (false);
			p1Choice2.SetActive (false);
			p1Choice3.SetActive (false);
			p1Choice1F.SetActive (false);
			p1Choice2F.SetActive (false);
			p1Choice3F.SetActive (false);
		}
	}
	void player2Dots() {
		if(player2.playerTwoActionPoints == 0) {
			p2Choice1.SetActive (true);
			p2Choice2.SetActive (true);
			p2Choice3.SetActive (true);
			p2Choice1F.SetActive(false);
			p2Choice2F.SetActive (false);
			p2Choice3F.SetActive (false);
		}
		if(player2.playerTwoActionPoints == 1) {
			p2Choice1.SetActive (true);
			p2Choice2.SetActive (true);
			p2Choice3.SetActive (true);
			p2Choice1F.SetActive (true);
		}
		if(player2.playerTwoActionPoints == 2) {
			p2Choice1.SetActive (true);
			p2Choice2.SetActive (true);
			p2Choice3.SetActive (true);
			p2Choice2F.SetActive(true);
		}
		if(player2.playerTwoActionPoints == 3) {
			p2Choice1.SetActive (true);
			p2Choice2.SetActive (true);
			p2Choice3.SetActive (true);
			p2Choice3F.SetActive (true);
		}
		if(timerCount <= 0) {
			p2Choice1.SetActive (false);
			p2Choice2.SetActive (false);
			p2Choice3.SetActive (false);
			p2Choice1F.SetActive (false);
			p2Choice2F.SetActive (false);
			p2Choice3F.SetActive (false);
		}

	}
}
