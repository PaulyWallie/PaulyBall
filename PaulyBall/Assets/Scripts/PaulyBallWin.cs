using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PaulyBallWin : MonoBehaviour {

	public GameObject ad;
	public GameObject nah;

	void OnTriggerEnter(Collider other ){
		if (PaulyBallBlock.breakableCount <= 0) {
			ad.SetActive(true);
			nah.SetActive(true);
		}
	}
}