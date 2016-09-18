using UnityEngine;
using System.Collections;

public class Rain : MonoBehaviour
{

	public Sprite pop;

	void OnCollisionEnter2D (Collision2D col)
	{
		if (this.gameObject.tag != col.gameObject.tag) {
			GetComponent <SpriteRenderer> ().sprite = pop;
			Destroy (this.gameObject, 0.5f);
		}
	}
}
