using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{

	int ranX;
	int ranY;

	public GameObject ball;

	void Start () 
	{
		Spawn();
	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Spawn();
		}
	
	}

	void CreateRandomPosition()
	{
		ranX = Random.Range(-8, 8);
		ranY = Random.Range(-4, 4);

	}


	void Spawn()
	{
		CreateRandomPosition();

		Instantiate ( ball, new Vector3(ranX, ranY, 0), Quaternion.identity);
	}
}
