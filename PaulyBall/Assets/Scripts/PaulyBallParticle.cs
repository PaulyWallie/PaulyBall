using UnityEngine;
using System.Collections;

public class PaulyBallParticle : MonoBehaviour {

	public GameObject particleObj;
	
	// Update is called once per frame
	void Update () {
		if(gameObject.tag == "breakable" && gameObject ==null) 
			Instantiate(particleObj, transform.position, Quaternion.identity);
	}

	void OnBecameInvisable(){
		Destroy (gameObject);
	}
}