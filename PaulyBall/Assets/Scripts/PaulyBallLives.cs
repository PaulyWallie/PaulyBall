using UnityEngine;
using System.Collections;

public class PaulyBallLives : MonoBehaviour {

	public static int lives = 3;

	TextMesh currLives;


	void Start () {
		currLives = GetComponent<TextMesh>();
	}

	void Update () {
		currLives.text = "Lives : " + lives;
	}
}