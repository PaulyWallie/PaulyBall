using UnityEngine;
using System.Collections;

public class PongQuit : MonoBehaviour {

	void Start (){
	}

	void OnMouseDown ()
	{
		transform.localScale *= 0.9F;
	}
	
	void OnMouseUp ()
	{
		Application.LoadLevel(3);

		}
	}