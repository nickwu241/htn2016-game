using UnityEngine;
using System.Collections;

public class Flame : MonoBehaviour
{
	public Sprite explosion;
	private float startTime;
	// Use this for initialization
	void Start()
	{
		startTime = Time.time;
	}

	void Update()
	{
		if (Time.time - startTime > 1.5)
		{
			explode();
		}
	}
	private void explode()
	{
		//GetComponentInChildren<SpriteRenderer>().sprite = explosion;
	}
	/*
	void OnTriggerEnter2D(Collision2D col)
	{
		if (this.gameObject.tag != col.gameObject.tag)
		{
			GetComponent<SpriteRenderer>().sprite = explode;
		}
	}
	*/
}
