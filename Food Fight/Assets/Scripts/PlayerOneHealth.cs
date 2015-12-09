using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerOneHealth : MonoBehaviour {
	public PlayerOneManager player1;
	public GameObject live1;
	public GameObject live2;
	public GameObject live3;
	public Sprite playerOne;
	public Sprite playerOneFood1;
	public Sprite playerOneFood2;

	private SpriteRenderer spriteRenderer;


	void Start () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		live1 = GameObject.Find ("P1Live1");
		live2 = GameObject.Find ("P1Live2");
		live3 = GameObject.Find ("P1Live3");
	}
	

	void Update () {
		changeSprite ();
		if(player1.playerOneHealth == 3) {
			live1.SetActive(true);
			live2.SetActive(true);
			live3.SetActive(true);
		}
		else if(player1.playerOneHealth == 2) {
			live1.SetActive(false);
		}
		else if(player1.playerOneHealth == 1) {
			live1.SetActive(false);
			live2.SetActive(false);
		}
	}
	void OnTriggerEnter2D(Collider2D food) {
		if(food.gameObject.tag == "food") {
			player1.playerOneHealth--;
		}
	}
	void changeSprite() {
		if(player1.playerOneFoodCount == 1) {
			spriteRenderer.sprite = playerOneFood1;
		}
		else if(player1.playerOneFoodCount >= 2) {
			spriteRenderer.sprite = playerOneFood2;
		}
		else {
			spriteRenderer.sprite = playerOne;
		}
	}
}
