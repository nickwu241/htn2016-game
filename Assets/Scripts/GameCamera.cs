using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour
{
	public float Y_OFFSET;
	private GameObject player;
	private Vector3 offset;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		offset = transform.position - player.transform.position;
	}

	void FixedUpdate ()
	{
		//Only move in X axis
		transform.position = new Vector3 (player.transform.position.x, Y_OFFSET, 0) + offset;
	}
}
