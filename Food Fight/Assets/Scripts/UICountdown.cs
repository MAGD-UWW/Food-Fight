using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UICountdown : MonoBehaviour {

		public float timeLeft = 6.0f;		
		public Text text;
		
		void Update()
		{
			timeLeft -= Time.deltaTime;
			text.text = "Start in: " + Mathf.Round(timeLeft);
			if(timeLeft < 0)
			{
				text.GetComponent<Text>().enabled = false;
			}
		}
	}