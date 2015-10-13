using UnityEngine;
using System.Collections;

public class PaulyBallSplash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("LoadLevel");
		}

	
	IEnumerator LoadLevel(){
		yield return new WaitForSeconds (6);
		Application.LoadLevel (1);
	}
}