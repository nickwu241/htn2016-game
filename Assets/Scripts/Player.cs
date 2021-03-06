﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float MAX_HEALTH;
	public int FLAME_DURATION;
	public int SPEED_MULTIPLIER;

	public float health { get; set; }

	private int flameTimer;
	private float startTime;

	public bool dead { get; set; }

	public bool onFire { get; set; }

	private Vector2 velocity;
	private Rigidbody2D rb2D;

	void Start ()
	{
		health = MAX_HEALTH;
		flameTimer = 0;
		rb2D = GetComponent<Rigidbody2D> ();
		velocity = new Vector2 (1, -rb2D.gravityScale * rb2D.mass / 9.8f);
		dead = false;
		onFire = false;
	}

	void FixedUpdate ()
	{
		if (health <= 0)
			dead = true;
		if (onFire && (Time.time - startTime) > 1) {
			health--;
			startTime++;
			flameTimer++;
			if (flameTimer >= FLAME_DURATION) {
				onFire = false;
			}
		}

		if (!dead) {
			rb2D.MovePosition (rb2D.position + velocity * SPEED_MULTIPLIER * Time.fixedDeltaTime);
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		string colTag = col.gameObject.tag;
		if (colTag.Equals ("Enemy")) {
			health--;
			transform.Translate (-5, 0, 0, Space.Self);
		} else if (colTag.Equals ("Rain")) {
			if (++health > MAX_HEALTH)
			{
				health = MAX_HEALTH;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("Flame")) {
			health--;
			startTime = Time.time;
			onFire = true;
		}
	}
}