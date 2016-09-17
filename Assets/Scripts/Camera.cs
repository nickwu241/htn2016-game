using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
	private GameObject player;
	private Vector3 offset;
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		offset = transform.position - player.transform.position;
	}

	void FixedUpdate()
	{
		//Only move in X axis
		transform.position = player.transform.position + offset;
	}
}
