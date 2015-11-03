using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	public float paddleSpeed = 0.1f;
	public Vector3 playerPos;

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPostion = Input.GetTouch(0).deltaPosition;

			transform.Translate(0,touchDeltaPostion.y * paddleSpeed, 0);
		}
	}
}
