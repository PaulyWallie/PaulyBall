using UnityEngine;
using System.Collections;

public class PaulyBallWin : MonoBehaviour {

	public GameObject Ball;

	void OnTriggerEnter(Collider other ){
		if (PaulyBallBlock.breakableCount <= 0) {
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
}
