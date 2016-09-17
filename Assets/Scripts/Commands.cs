using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Commands : NetworkBehaviour
{

	public int command;

	public GameObject rainPrefab;
	public Transform rainSpawn;
	//stores the current command number

	// Use this for initialization
	void Start ()
	{
		rainPrefab = GameObject.FindGameObjectWithTag("Rain");
		command = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		switchCommand ();
		//print ("Command: " + command);
		switch (command) {
		case 1:
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				summon ();
			}
			break;
		}
	}

	void switchCommand ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			command = 1;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			command = 2;
		}
	}

	void summon (/*GameObject spawnee*/)
	{
		
		//print ("Mouse pos: " + Camera.main.ScreenToWorldPoint (Input.mousePosition));
		//Instantiate (rain, Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.rotation);
		//element = new GameObject ("Click and they will come");
		var rain = (GameObject)Instantiate (
			           rainPrefab,
			           rainSpawn.position,
			           rainSpawn.rotation);
		
		//rain.GetComponent<Rigidbody2D> ().velocity = rain.transform.forward * 2;
	}

	public override void OnStartLocalPlayer ()
	{
		GetComponent<MeshRenderer> ().material.color = Color.blue;
	}

}