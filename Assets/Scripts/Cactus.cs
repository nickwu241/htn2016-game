using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour
{
	//public Sprite alive;
	public Sprite burnt;

	// Use this for initialization
	void Start ()
	{
		//GetComponent<SpriteRenderer> ().sprite = alive;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//print (col.gameObject.name + "you bad");
		if (other.gameObject.tag.Equals ("Flame")) {
			GetComponent<SpriteRenderer> ().sprite = burnt;
		}
	}
}
