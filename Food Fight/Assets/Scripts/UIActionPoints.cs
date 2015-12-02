using UnityEngine;
using System.Collections;

public class UIActionPoints : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	//Player 1's points P1.1, P1.2, P1.3
	public GameObject p11;
	public GameObject p12;
	public GameObject p13;
	//Player 2's points p2.1, p2.2, p2.3
	public GameObject p21;
	public GameObject p22;
	public GameObject p23;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager> ();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager> ();

	}
	
	// Update is called once per frame
	//Set player 1's & 2's UI to disappear if Actoin Points are 0
	void Update () {
		if (player1.playerOneActionPoints == 0) {
			p11.SetActive (false);
			p12.SetActive (false);
			p13.SetActive (false);
		}
		if (player2.playerTwoActionPoints == 0) {
			p21.SetActive (false);
			p22.SetActive (false);
			p23.SetActive (false);
		}
		//Activates each UI point with each Action Point
		if (player1.playerOneActionPoints == 1)
			p11.SetActive(true);
		if (player1.playerOneActionPoints == 2)
			p12.SetActive(true);
		if (player1.playerOneActionPoints == 3)
			p13.SetActive(true);
		//Activate each UI point with each Action Point
		if (player2.playerTwoActionPoints == 1)
			p21.SetActive (true);
		if (player2.playerTwoActionPoints == 2)
			p22.SetActive(true);
		if (player2.playerTwoActionPoints == 3)
			p23.SetActive(true);
	}
}
