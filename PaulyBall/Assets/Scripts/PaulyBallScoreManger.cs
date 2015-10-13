using UnityEngine;
using System.Collections;

public class PaulyBallScoreManger : MonoBehaviour {

	public static int comboScore;

	TextMesh text;
	
	void Start () {
		text = GetComponent<TextMesh>();
		comboScore = 0;
	}

	void Update () {

		text.text = "" + comboScore;
	}
}