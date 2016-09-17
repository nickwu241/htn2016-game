using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public int START_HEALTH;
	private static Vector2 KB_VECT = Vector2.left;
	public int health { get; set; }
	private int flameTimer;
	private float startTime;
	public bool dead { get; set; }
	public bool onFire { get; set; }
	private Vector2 velocity;
	private Rigidbody2D rb2D;

	void Start()
	{
		health = START_HEALTH;
		flameTimer = 0;
		velocity = Vector2.right;
		rb2D = GetComponent<Rigidbody2D>();
		dead = false;
		onFire = false;
	}

	void FixedUpdate()
	{
		if (health <= 0) dead = true;
		if (onFire && (Time.time - startTime) > 1)
		{
			print(health);
			health--;
			startTime++;
			flameTimer++;
			if (flameTimer >= 5)
			{
				onFire = false;
			}
		}

		if (!dead)
		{
			rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		string colTag = col.gameObject.tag;
		if (colTag.Equals("Enemy"))
		{
			print("hit");
			health--;
			rb2D.MovePosition(rb2D.position + KB_VECT * Time.fixedDeltaTime);
		}
		else if (colTag.Equals("Rain"))
		{
			health++;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("Flame"))
		{
			print("touch Flame");
			health--;
			startTime = Time.time;
			onFire = true;
		}
	}
}
