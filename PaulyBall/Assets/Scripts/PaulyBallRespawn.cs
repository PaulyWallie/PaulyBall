using UnityEngine;
using System.Collections;

public class PaulyBallRespawn : MonoBehaviour {

	public GameObject ballPref;
	public Transform paddleObj;
	
	GameObject ball;
	int score;
	
	void Update () 
	{
		ball = GameObject.FindGameObjectWithTag("Ball");

	}
	
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Ball")
		{
			Destroy(ball);
			PaulyBallScoreManger.comboScore -= 50;
			PaulyBallLives.lives -= 1;
			Reset();
			(Instantiate(ballPref, new Vector3(paddleObj.transform.position.x + 0.4f, paddleObj.transform.position.y ), Quaternion.identity) as GameObject).transform.parent = paddleObj;
		}
	}

	void Reset(){
		if(PaulyBallLives.lives <= 0) {
			Application.LoadLevel(5);
			PaulyBallLives.lives = 3;
		}
	}
}