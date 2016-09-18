using UnityEngine;
using System.Collections;

public class FinishFlag : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D col)
	{
		string colTag = col.gameObject.tag;
		if (colTag.Equals("Player"))
		{
			col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
		}
	}
}
