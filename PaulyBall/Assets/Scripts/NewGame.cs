using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour 
{
	void onMouseDown()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp()
	{
		Application.LoadLevel (4);
	}
}