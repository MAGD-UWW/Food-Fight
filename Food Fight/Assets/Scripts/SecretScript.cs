using UnityEngine;
using System.Collections;

public class SecretScript : MonoBehaviour {
	public PlayerOneManager player1;
	public PlayerTwoManager player2;
	public GameObject bouldarMode; //Put text on the table, 
	public AudioSource foodSound;
	public AudioClip foodClip;
	public AudioSource bouldarSound;
	public AudioClip bouldClip;
	public bool bouldarPowerP1;
	public bool bouldarPowerP2;
	public SpriteRenderer renderer1;
	public SpriteRenderer renderer2;
	public Sprite bouldar;


	void Start() {
		player1 = GameObject.Find ("Manager").GetComponent<PlayerOneManager>();
		player2 = GameObject.Find ("Manager").GetComponent<PlayerTwoManager>();
		bouldarMode = GameObject.Find ("bouldarMode");
		bouldarMode.SetActive(false);
		renderer1 = GameObject.Find ("Player1").GetComponent<SpriteRenderer>();
		renderer2 = GameObject.Find ("Player2").GetComponent<SpriteRenderer>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.PageUp)) {
			foodSound.Stop();
			bouldarSound.Play ();
			bouldarMode.SetActive(true);
			bouldarPowerP1 = true;
		}
		if(Input.GetKeyDown (KeyCode.PageDown)) {
			foodSound.Stop();
			bouldarSound.Play();
			bouldarMode.SetActive(true);
			bouldarPowerP2 = true;
		}
		if(bouldarPowerP1 == true) {
			renderer1.sprite = bouldar;
		}
		if(bouldarPowerP2 == true) {
			renderer2.sprite = bouldar;
		}
	}
}
