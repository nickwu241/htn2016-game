using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour
{
	//public Sprite alive;
	public Sprite burnt;
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		//print (gameObject.GetComponent<SpriteRenderer> ().sprite);
		//GetComponent<SpriteRenderer> ().sprite = alive;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("Flame")) {
			print (other + " you bad");
			anim.enabled = false;
			gameObject.GetComponent<SpriteRenderer> ().sprite = burnt;
		}
	}
}
