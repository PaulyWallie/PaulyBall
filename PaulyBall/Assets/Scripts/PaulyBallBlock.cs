using UnityEngine;
using System.Collections;

public class PaulyBallBlock : MonoBehaviour {

	public GameObject particleObj;
	public static int breakableCount = 0;

	bool isBreakable;

	void Start () {
		isBreakable = (this.tag =="Breakable");
		// Kepp track of breakable blocks.
		if(isBreakable){
			breakableCount++;
		}
	}
	
	void HandleHits(){
		breakableCount--;
		Destroy(gameObject);
		PaulyBallScoreManger.comboScore += 100;
		GameObject particle = Instantiate(particleObj, transform.position, Quaternion.identity) as GameObject; 
		Destroy(particle, 5);
	}

	void OnCollisionEnter(Collision col){
		if(tag == "Breakable"){
			HandleHits();
		}
	}
}