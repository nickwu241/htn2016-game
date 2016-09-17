using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	private static Vector2 KB_VECT = Vector2.left;

	public int health { get; set; }
	public bool dead { get; set; }
	private Vector2 velocity;
	private Rigidbody2D rb2D;

	void Start()
	{
		health = 10;
		velocity = Vector2.right;
		rb2D = GetComponent<Rigidbody2D>();
		dead = false;
	}

	void FixedUpdate()
	{
		if (health <= 0) dead = true;

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
			health--;
			rb2D.MovePosition(KB_VECT * Time.fixedDeltaTime);
		}
		else if (colTag.Equals("Fire"))
		{
			//
		}
		else if (colTag.Equals("Water"))
		{
			//
		}
	}
}
