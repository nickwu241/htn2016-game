using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public static int health;

	// Use this for initialization
	void Start () {
		health = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameState.move) {
			print (health);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				transform.Translate (1, 0, 0);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		print ("!");
		if (col.gameObject.tag == "Enemy") {
			health--;
			transform.Translate (-2,0,0);
		}
	}
}
