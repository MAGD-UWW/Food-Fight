using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToMainGame : MonoBehaviour {
	public GameObject pressC;
	public bool blink;
	void Start() {
		pressC = GameObject.Find ("Continue");
		pressC.SetActive(false);
		StartCoroutine("WaitABit");
	}
	IEnumerator WaitABit() {
		yield return new WaitForSeconds(15);
		pressC.SetActive (true);
		blink = true;
		while(blink == true) {
		yield return new WaitForSeconds(0.2f);
		pressC.SetActive (false);
		yield return new WaitForSeconds(0.2f);
		pressC.SetActive (true);
		}
	}
	void OnMouseOver() {
		if(Input.GetMouseButtonDown (0)){
			Application.LoadLevel ("Main");
		}
	}
}
