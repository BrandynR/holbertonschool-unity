using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour {

	[SerializeField]
	public GameObject ball;
	public Transform ammoHolder;

	public void Spawn()
	{
		ball.SetActive(true);
		Instantiate(ball, ammoHolder.position, Quaternion.identity);
	}
}
