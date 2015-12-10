using UnityEngine;
using System.Collections;

public class FoodTossP2 : MonoBehaviour {
	public ExecutionScript exeScript;
	public Rigidbody2D mushBody;
	public AudioSource splatSource;
	public AudioClip splatClip;

	void Start () {
		mushBody = gameObject.GetComponent<Rigidbody2D>();
		exeScript = GameObject.Find ("Execution").GetComponent<ExecutionScript>();
		splatSource = GameObject.Find ("Splat").GetComponent<AudioSource>();
	}

	void Update () {
		if(exeScript.pos1Toss == true) {
			Vector3 newPos = (exeScript.pos1.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x < -1.2 && transform.position.y > 2) {
				exeScript.pos1Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos2Toss == true) {
			Vector3 newPos = (exeScript.pos2.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x < -.1 && transform.position.y > 2) {
				exeScript.pos2Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos3Toss == true) {
			Vector3 newPos = (exeScript.pos3.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x > 0.8 && transform.position.y > 2.0 ) {
				exeScript.pos3Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos4Toss == true) {
			Vector3 newPos = (exeScript.pos4.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x > 2 && transform.position.y > 2) {
				exeScript.pos4Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos5Toss == true) {
			Vector3 newPos = (exeScript.pos5.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x > 3.2 && transform.position.y > 2) {
				exeScript.pos5Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
	}
}
