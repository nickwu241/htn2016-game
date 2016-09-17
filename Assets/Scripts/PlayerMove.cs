using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public static int health;
	private Vector2 velocity;
	private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		health = 2;
		velocity = Vector2.right;
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
		rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
	}
	/*
	// Update is called once per frame
	void Update () {
		if (GameState.move) {
			print (health);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				transform.Translate (1, 0, 0);
			}
		}
	}
	*/
	void OnCollisionEnter2D(Collision2D col){
		print ("!");
		if (col.gameObject.tag == "Enemy") {
			health--;
			rb2D.AddForce(col.gameObject.GetComponent<Vector2>() * Time.fixedDeltaTime);
			//transform.Translate (-2,0,0);
		}
	}
}
