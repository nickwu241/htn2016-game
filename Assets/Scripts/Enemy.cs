﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	public static int killed = 0;
	// TODO: Walk towards player
	// Set in Unity
	public int health;

	public bool dead { set; get; }

	void Start ()
	{
		health = 5;
	}

	void FixedUpdate ()
	{
		if (health <= 0)
			dead = true;

		if (dead) {
			killed++;
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		string colTag = col.gameObject.tag;
		if (colTag.Equals ("Flame")) {
			health--;
		} else if (colTag.Equals ("Water")) {
			//
		}
	}
}
