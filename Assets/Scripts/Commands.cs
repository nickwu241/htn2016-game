using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;

public class Commands : MonoBehaviour
{
	private new Camera camera;
	private List<GameObject> tools;
	private int toolIndex;

	void Start ()
	{
		//gameObject.GetComponentInChildren<Flame>();
		tools = new List<GameObject>();
		tools.Add(GameObject.FindGameObjectWithTag("Rain")); // 0
		tools.Add(GameObject.FindGameObjectWithTag("Flame")); // 1
		tools.Add(GameObject.FindGameObjectWithTag("Circle")); // 2
		camera = Camera.main;
		toolIndex = 0;
	}
	
	// Update is called once per frame
	void Update() {
		checkInput();
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
			create(tools[toolIndex]);
		}
		else if (toolIndex == 2 && Input.GetKey(KeyCode.Mouse0))
		{
			transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
			create(tools[toolIndex]);
		}
	}

	void checkInput()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			toolIndex = 0;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			toolIndex = 1;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			toolIndex = 2;
		}
	}

	void create(GameObject obj)
	{
		//print ("Mouse pos: " + Camera.main.ScreenToWorldPoint (Input.mousePosition));
		GameObject clone = (GameObject) Instantiate (obj, transform.position, transform.rotation);
		if (toolIndex == 1)
		{
			Destroy(clone, 3);
		}
		else if (toolIndex == 2)
		{
			Destroy(clone, 5);
		}
	}
}