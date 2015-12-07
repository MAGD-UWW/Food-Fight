using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerTwoHealth : MonoBehaviour {
	public PlayerTwoManager player2;
	public Text Health;
	public Sprite playerTwo;
	public Sprite playerTwoFood;

	private SpriteRenderer spriteRenderer;
	
	
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
	}
	
	
	void Update () {
		Health.text = player2.playerTwoHealth.ToString();
		changeSprite ();
	}
	void OnTriggerEnter2D(Collider2D food) {
		if(food.gameObject.tag == "food2") {
			player2.playerTwoHealth -= 25;
		}
	}
	void changeSprite() {
		if(player2.playerTwoFoodCount >= 1) {
			spriteRenderer.sprite = playerTwoFood;
		}
		else {
			spriteRenderer.sprite = playerTwo;
		}
	}
}
