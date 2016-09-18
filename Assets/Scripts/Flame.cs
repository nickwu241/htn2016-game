﻿using UnityEngine;
using System.Collections;

public class Flame : MonoBehaviour
{
	public Sprite explosion;
	public Sprite ignite;
	private float startTime;
	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer> ().sprite = ignite;
		startTime = Time.time;
		print (Time.time);
	}

	void Update ()
	{
		print (Time.time);
		if (Time.time - startTime > 1.5) {
			explode ();
		}
	}

	private void explode ()
	{
		GetComponent<SpriteRenderer> ().sprite = explosion;
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
