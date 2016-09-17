using UnityEngine;
using System.Collections;

public class Rain : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		if (this.gameObject.tag != col.gameObject.tag)
		{
			Destroy(this.gameObject);
		}
	}
}
