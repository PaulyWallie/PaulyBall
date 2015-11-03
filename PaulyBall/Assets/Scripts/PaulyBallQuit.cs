using UnityEngine;
using System.Collections;

public class PaulyBallQuit : MonoBehaviour 
{
	void OnMouseDown ()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp ()
	{
		Application.Quit ();
	}
}
