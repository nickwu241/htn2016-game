using UnityEngine;
using System.Collections;

//using UnityEngine.Networking;

public class Spawn : MonoBehaviour
{
	new Camera camera;

	// Use this for initialization
	void Start ()
	{
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) {	
			transform.position = new Vector3 (camera.ScreenToWorldPoint (Input.mousePosition).x, camera.ScreenToWorldPoint (Input.mousePosition).y, 0);
		}
	}

	/*public override void OnStartLocalPlayer ()
	{
		GetComponent<SpriteRenderer> ().material.color = Color.blue;
	}*/
}