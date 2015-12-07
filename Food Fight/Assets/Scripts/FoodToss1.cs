using UnityEngine;
using System.Collections;

public class FoodToss1 : MonoBehaviour {
	public ExecutionScript exeScript;
	public Rigidbody2D mushBody;
	public AudioSource splatSource;
	public AudioClip splatClip;

	void Start () {
		exeScript = GameObject.Find ("Execution").GetComponent<ExecutionScript>();
		mushBody = GetComponent<Rigidbody2D>();
		splatSource = GameObject.Find ("Splat").GetComponent<AudioSource>();
	}
	

	void Update () {
		if(exeScript.pos6Toss == true) {
			Vector3 newPos = (exeScript.pos6.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x < -3.8 && transform.position.y < -3.0) {
				exeScript.pos6Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos7Toss == true) {
			Vector3 newPos = (exeScript.pos7.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x < -2.6 && transform.position.y < -3.0) {
				exeScript.pos7Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos8Toss == true) {
			Vector3 newPos = (exeScript.pos8.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x < -1.2 && transform.position.y < -3.3) {
				exeScript.pos8Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos9Toss == true) {
			Vector3 newPos = (exeScript.pos9.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x > .045 && transform.position.y < -3.5) {
				exeScript.pos9Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
		if(exeScript.pos10Toss == true) {
			Vector3 newPos = (exeScript.pos10.position - transform.position);
			mushBody.velocity = newPos * 5;
			if(transform.position.x > 1.4 && transform.position.y < -3.6) {
				exeScript.pos10Toss = false;
				splatSource.Play ();
				Destroy (this.gameObject);
			}
		}
	}
}
