using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour {

	[SerializeField]
	public GameObject ball;

	public void Spawn()
	{
		ball.SetActive(true);
		Instantiate (ball, new Vector3(0f, 1f, -8f), Quaternion.identity);
	}
}
