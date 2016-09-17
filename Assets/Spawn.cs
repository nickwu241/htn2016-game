using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		print (Camera.main.ScreenToWorldPoint (Input.mousePosition));
	}
}