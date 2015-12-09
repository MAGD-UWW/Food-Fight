using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerTwoHealth : MonoBehaviour {
	public PlayerTwoManager player2;
	public GameObject live1;
	public GameObject live2;
	public GameObject live3;
	
	
	void Start () {
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		live1 = GameObject.Find ("P2Live1");
		live2 = GameObject.Find ("P2Live2");
		live3 = GameObject.Find ("P2Live3");
	}
	
	
	void Update () {
		if(player2.playerTwoHealth == 3) {
			live1.SetActive(true);
			live2.SetActive(true);
			live3.SetActive(true);
		}
		else if(player2.playerTwoHealth == 2) {
			live1.SetActive(false);
		}
		else if(player2.playerTwoHealth == 1) {
			live1.SetActive(false);
			live2.SetActive(false);
		}
	}
	void OnTriggerEnter2D(Collider2D food) {
		if(food.gameObject.tag == "food2") {
			player2.playerTwoHealth --;
		}
	}
}
