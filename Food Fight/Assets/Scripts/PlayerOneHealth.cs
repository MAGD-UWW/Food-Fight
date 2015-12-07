using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerOneHealth : MonoBehaviour {
	public PlayerOneManager player1;
	public Text Health;
	public Sprite playerOne;
	public Sprite playerOneFood1;
	public Sprite playerOneFood2;

	private SpriteRenderer spriteRenderer;


	void Start () {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	

	void Update () {
		Health.text = player1.playerOneHealth.ToString();
		changeSprite ();
	}
	void OnTriggerEnter2D(Collider2D food) {
		if(food.gameObject.tag == "food") {
			player1.playerOneHealth -= 25;
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
