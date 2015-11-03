using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class PaulyBallRespawn : MonoBehaviour {

	public GameObject ballPref;
	public Transform paddleObj;

	GameObject ball;
	static int counter;
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
			counter++;
			if(counter >= 3){
				ShowRewardedAd();
				counter = 0;
			}else{
				Application.LoadLevel(Application.loadedLevel);
				PaulyBallLives.lives = 3;
			}
		}
	}

	public void ShowRewardedAd()
	{
		if (Advertisement.IsReady("rewardedVideo"))
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show("rewardedVideo", options);
		}
	}
	
	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log("The ad was successfully shown.");
			//
			// YOUR CODE TO REWARD THE GAMER
			// Give coins etc.
			PaulyBallLives.lives += 4;
			Application.LoadLevel(Application.loadedLevel);
			break;
			
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			Application.LoadLevel(Application.loadedLevel);
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			Application.LoadLevel(Application.loadedLevel);
			break;
		}
	}

}