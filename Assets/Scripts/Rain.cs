using UnityEngine;
using System.Collections;

public class Rain : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy(this.gameObject);
	}
}
