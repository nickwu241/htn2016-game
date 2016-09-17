using UnityEngine;
using System.Collections;

//using UnityEngine.Networking;

public class Spawn : MonoBehaviour
{
	private new Camera camera;
	
	void Start ()
	{
		camera = Camera.main;
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) {	
			transform.position = new Vector3 (camera.ScreenToWorldPoint (Input.mousePosition).x, camera.ScreenToWorldPoint (Input.mousePosition).y, 0);
		}
	}
}