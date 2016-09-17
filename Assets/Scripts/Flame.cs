using UnityEngine;
using System.Collections;

public class Flame : MonoBehaviour {
	GameObject touched;
	void OnTriggerEnter2D(Collider2D other)
	{
		touched = other.gameObject;
	}

	public GameObject touch()
	{
		return touched;
	}
}
