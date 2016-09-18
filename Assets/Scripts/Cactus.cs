using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour
{
	public static int killed = 0;
	private bool dead { get; set; }

	//public Sprite alive;
	public Sprite burnt;
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		dead = false;
		//print (gameObject.GetComponent<SpriteRenderer> ().sprite);
		//GetComponent<SpriteRenderer> ().sprite = alive;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (!dead && other.gameObject.tag.Equals ("Flame")) {
			anim.enabled = false;
			gameObject.GetComponent<SpriteRenderer> ().sprite = burnt;
			killed++;
			dead = true;
		}
	}
}
