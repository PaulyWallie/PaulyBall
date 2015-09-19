using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float ballVelocity = 3000;

	Rigidbody rb;
	bool isPlay;
	int ranInt;

	void Awake ()
	{
		rb = gameObject.GetComponent<Rigidbody> ();
		ranInt = Random.Range (1, 3);
	}
	

	void Update () 
	{
		if(Input.GetMouseButton(0) == true && isPlay == false)
		{
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			if(ranInt == 1)
			{
				rb.AddForce(new Vector3(ballVelocity,ballVelocity,0));
			}	
			if(ranInt == 2)
			{
				rb.AddForce(new Vector3(-ballVelocity,-ballVelocity,0));
			}
		}
	}
}
