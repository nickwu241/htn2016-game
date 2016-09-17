using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Vector2 knockbackV;
	// Use this for initialization
	void Start () {
		knockbackV = Vector2.left;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}
