using UnityEngine;
using System.Collections;

public class ToMainGame : MonoBehaviour {

	void OnMouseOver() {
		if(Input.GetMouseButtonDown (0)){
			Application.LoadLevel ("Main");
		}
	}
}
