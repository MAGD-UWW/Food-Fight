using UnityEngine;
using System.Collections;

public class toTutorial : MonoBehaviour {

	void OnMouseOver() {
		if(Input.GetMouseButtonDown (0)){
			Application.LoadLevel ("Tutorial");
		}
	}
}
