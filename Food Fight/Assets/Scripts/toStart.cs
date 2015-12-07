using UnityEngine;
using System.Collections;

public class toStart : MonoBehaviour {

	void OnMouseOver() {
		if(Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("StartScreen");
		}
	}
}
