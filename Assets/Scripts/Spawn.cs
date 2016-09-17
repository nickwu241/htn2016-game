using UnityEngine;
using System.Collections;

//using UnityEngine.Networking;

public class Spawn : MonoBehaviour
{
	//Camera camera;

	// Use this for initialization
	void Start ()
	{
		//camera = GameObject.FindGameObjectWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) {	
			transform.position = new Vector3 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y, 0);
			print (Camera.main.ScreenToWorldPoint (Input.mousePosition));
		}
	}

	/*public override void OnStartLocalPlayer ()
	{
		GetComponent<SpriteRenderer> ().material.color = Color.blue;
	}*/
}