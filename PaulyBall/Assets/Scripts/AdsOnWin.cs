using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class AdsOnWin: MonoBehaviour {
	public GameObject ad;
	public GameObject nah;
	
	void OnTriggerEnter(Collider other ){
		if (PaulyBallBlock.breakableCount <= 0) {
			DestroyOnWin();
			ad.SetActive (true);
			nah.SetActive (true);
		}
	}

	void DestroyOnWin(){
		GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag ("DestroyOnWin");

		foreach (GameObject taggedObject in taggedObjects) {
			Destroy(taggedObject);
		} 
	}

	public void LoadNextLevel (){
		Application.LoadLevel (Application.loadedLevel + 1);
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
			PaulyBallLives.lives += 1;
			Application.LoadLevel(Application.loadedLevel +1);
			break;

		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			Application.LoadLevel(Application.loadedLevel +1);
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			Application.LoadLevel(Application.loadedLevel +1);
			break;
		}
	}
}