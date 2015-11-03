using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private MusicPlayer instance = null;

	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
		}else{
			instance = this;
		}
	}
}
